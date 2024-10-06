-- このluaスクリプトは、CO_101013_0301.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end

function Play()
	StartPlayActive()

	--★★ガウェイン★★:キンイロチョウ探しに<br>付き合ってくれるよな？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101013_03010004","CO_101013_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:トムのためだもんな<br>もちろん付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03010007")

	change_face(Actor002,"Smile")

	--★★ガウェイン★★:さっすが！<br>ノワールは話が早くて助かるぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03010008")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:ラグネルも付き合ってくれるそうだからさ<br>トムを誘って出かけようぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03010009")

	reserve_next_script("1章/コミュ/x0401_ガウェイン_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Sad")

	--★★ノワール★★:えっ？<br>い、いや、俺はちょっと遠慮しとく…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_03010011")

	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:なんだ、先約でもあんのか？<br>ここで待ってるからよ、協力頼むぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_03010012")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ
	InitializeActiveCharacter_Preload("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("Gawain","101013001","101013001","content_animationpack_101_101gawa","MotionPack_101Gawa","Com_Std01_Loop_m")
end
