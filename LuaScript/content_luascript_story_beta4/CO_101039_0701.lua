-- このluaスクリプトは、CO_101039_0701.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Flen","101039001","101039001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★フレン★★:こないだの一件以来<br>陸上部の集まりがめっきり悪くなってるんだって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101039_07010004","CO_101039_07010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:フレン<br>甘いものでも食べに行こうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07010007")

	change_face(Actor002,"Surprise")

	--★★フレン★★:えっ、甘いもの？<br>突然どうして？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:元気がないときは甘いものを<br>食べるといいって聞いたことがある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07010009")

	change_face(Actor002,"Normal")

	--★★フレン★★:そんなに私<br>元気ないように見える？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07010010")

	change_face(Actor001,"Normal")

	--★★ノワール★★:見える
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07010011")

	change_face(Actor002,"Surprise")

	--★★フレン★★:断言されちゃった！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07010012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:だからほら、食堂に行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07010013")

	reserve_next_script("1章/コミュ/x0401_フレン_ランクアップ7_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:そうなのか、でもごめん<br>今は用事があって相談に乗ってやれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_07010015")

	change_face(Actor002,"Surprise")

	--★★フレン★★:あっ！うん、私なら大丈夫だよ<br>ごめんね、愚痴を聞かせちゃって
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_07010016")

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
	InitializeActiveCharacter_Preload("Flen","101039001","101039001","content_animationpack_100_100srif","MotionPack_100SriF","Com_Std01_Loop_f")
end
