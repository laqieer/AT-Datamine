-- このluaスクリプトは、CO_101025_0601.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")

function Load()
	commu = system.GetCommu()
	commuChara = commu.GetCharacter() -- コミュキャラ

	InitializeLoadActive()
	Actor001 = InitializeActiveCharacter("Player","101009002","101009002","content_animationpack_101_101noir","MotionPack_101Noir","Com_Std01_Loop_m")
	Actor002 = InitializeActiveCharacter("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
--	Actor003 = InitializeActiveCharacter("Bors","101024001","101024001","content_animationpack_101_101bors","MotionPack_101Bors","Com_Std01_Loop_m")
--	Actor003 = InitializeCharacter_2DOnly("101024","001","101024001")

	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")

	set_pos(Actor003, {-0.2+0.5, 0.01-3, -34.5+1})	-- クレアの座標から相対配置。ただし一旦画面外に配置
	set_rot(Actor003, {0,-45+0,0})
	set_animationcontroller_path(Actor003, "content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop")

	off_active(Actor003)

end

function Play()
	StartPlayActive()

	--★★クレア★★:ノワール<br>今、時間とれるかしら
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06010001")
	CloseTalkWindow()

	kizuna_rankup_condition()	-- 進行条件示唆

	if commu.IsRankup == false then -- ランクアップ条件を満たしていない
		system.Cancel()
		goto Block1end
	end

	kizuna_rankup_hint()		-- ランクアップ示唆

	open_select_window_tag(Actor001,"Normal","CO_101025_06010003","CO_101025_06010004")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ、大丈夫だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06010006")

	change_face(Actor002,"Normal")

	--★★クレア★★:少しこれまでの事件を<br>振り返って整理しておきたいのだけど…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06010007")


	CloseTalkWindow()

	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

	set_pos(Actor003, {-0.2+0.5, 0.01, -34.5+1})
	on_active(Actor003)

	fadein(CHARA_IN_OUT)
	wait_time(CHARA_IN_OUT)


	change_face(Actor003,"Normal")

	--★★ヴォールス★★:クレア<br>緊急の案件だ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_06010009")

	change_face(Actor003,"Normal")

	--★★ヴォールス★★:男がひとり<br>バルバロイに襲われて命を落とした
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_06010010")

	change_face(Actor002,"Normal")

	--★★クレア★★:…予定変更よ<br>事件現場へ向かいましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06010012")

	reserve_next_script("1章/コミュ/x0401_クレア_ランクアップ6_2")

	fadeout(0,0,0,1.0, CHARA_IN_IN)
	wait_time(CHARA_IN_IN + CHARA_IN_WAIT)

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:悪いけど、今は時間がない<br>またあとでな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_06010014")

	change_face(Actor002,"Normal")

	--★★クレア★★:そう、残念ね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_06010015")

	system.Cancel()

	goto Block1end

::Block1end::
	EndPlayActive()

	kill(Actor003)	-- 念のため追加登録したキャラをデモ終了時に破棄

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
	InitializeActiveCharacter_Preload("Clare","101025001","101025001","content_animationpack_101_101clar","MotionPack_101Clar","Com_Std01_Loop_f")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
end
