-- このluaスクリプトは、CO_101065_1001.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()

	--★★キッス★★:ラビットちゃんに渡したい情報がいろいろあるの<br>寄って行ってくれる？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101065_10010004","CO_101065_10010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、もちろん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10010007")

	change_face(Actor002,"Smile")

	--★★キッス★★:さっすがラビットちゃん♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10010008")

	change_face(Actor001,"Normal")

	--★★ノワール★★:それで<br>渡したい情報っていうのはなんなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10010009")

	change_face(Actor002,"Normal")

	--★★キッス★★:アタシが今持ってる<br>バルバロイ信者関連の情報全部よ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10010010")

	change_face(Actor002,"Smile")

	--★★キッス★★:ケイ卿に持って行ってあげたら<br>きっと喜ぶわ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10010011")

	change_face(Actor001,"Smile")

	--★★ノワール★★:それは助かる！<br>ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10010012")

	reserve_next_script("1章/コミュ/x0401_キッス_ランクアップ10_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん、これからちょっと用事がある
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_10010014")

	change_face(Actor002,"Normal")

	--★★キッス★★:あら、残念<br>都合のいいときにまた声かけてね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_10010015")

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
	InitializeActiveCharacter_Preload("Kiss","101065001","101065001","content_animationpack_101_101kiss","MotionPack_101Kiss","Com_Std01_Loop_f")
end
