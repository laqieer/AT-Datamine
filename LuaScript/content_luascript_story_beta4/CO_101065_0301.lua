-- このluaスクリプトは、CO_101065_0301.csv の ADV シートから自動生成されました --
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

	--★★キッス★★:あら、ラビットちゃん♪<br>今日はどうしたの？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03010002")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101065_03010004","CO_101065_03010005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:このあいだの依頼の完了報告に来た
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03010007")

	change_face(Actor002,"Surprise")

	--★★キッス★★:あら、もう終わったの？<br>やるじゃない♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03010008")

	change_face(Actor002,"Smile")

	--★★キッス★★:それじゃ、ご褒美をあげないとね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03010009")

	reserve_next_script("1章/コミュ/x0401_キッス_ランクアップ3_2")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、なんでもない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_03010011")

	change_face(Actor002,"Normal")

	--★★キッス★★:あら、つれない反応<br>また口説きに来てね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_03010012")

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
