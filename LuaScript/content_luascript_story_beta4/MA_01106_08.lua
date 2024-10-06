-- このluaスクリプトは、MA_01106_08.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera004 = SetTemplate("Actor004",-20,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_517_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
Hide(Actor003)
set_enable_auto_lookat(Actor001,false)
lookat_weight(Actor001,0.7, 0.03, 0.7, 0.5)
keep_ik_lookat(Actor001,Actor004,"J_Head")
set_enable_auto_lookat(Actor002,false)
lookat_weight(Actor002,0.7, 0.03, 0.7, 0.5)
keep_ik_lookat(Actor002,Actor004,"J_Head")
set_enable_auto_lookat(Actor004,false)
lookat_weight(Actor004,0.7, 0.03, 0.7, 0.5)
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_2DOnly("101032","001","101032001")
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★リオネス★★:Ａランチふたつ<br>おまちどー！
	Talk(Actor004,"NPCNAME_0073","speech","L","MA_01106_080002")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★リオネス★★:ひとつは大盛にしといたぞ！<br>あたしからのサービスだ！
	Talk(Actor004,"NPCNAME_0073","speech","L","MA_01106_080003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あ、ありがとう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_080004")


	--★★リオネス★★:お代はキャメリアード攻略の勝利で<br>じゅうぶんもらってるからなっ！！
	Talk(Actor004,"NPCNAME_0073","speech","L","MA_01106_080005")

-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor002,"J_Head",1)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★リオネス★★:ん？<br>んーーーー？？
	Talk(Actor004,"NPCNAME_0073","speech","L","MA_01106_080007")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:わ、私になにか…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01106_080009")

-- ▼直接出力
wait_time(1.0)
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ガレス★★:リオネス～<br>次のお客さん待ってるぞ～
	Talk(Actor005,"NPCNAME_0072","speech","L","MA_01106_080011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
--リオネス,CHRNAME_LYONESS @名前変更
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
lookat_delay_weight(Actor004,1, 0.03, 0.7, 0.5,1)
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★リオネス★★:あっ、おう！<br>わかったガレス、すぐ行くー！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01106_080012")

-- ▼直接出力
OpenFirstAppearance(Actor004)
--ガレス,CHRNAME_GARETH @名前変更
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ガレス★★:できたてホッカホカ～♪<br>冷めないうちに運ぶんだぞ～！
	Talk(Actor005,"CHRNAME_GARETH","speech","L","MA_01106_080013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to Greet_one")
-- ▼直接出力
keep_delay_ik_lookat(Actor004,Actor001,"J_Head",1)
-- ▲直接出力

	--★★リオネス★★:じゃ、またなー！
	Talk(Actor004,"CHRNAME_LYONESS","speech","L","MA_01106_080014")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor004)
Appear(Actor003)
setup_small_camera_end(RndCamera001)
setup_template_moveobj_110122_01(6,true)
setup_small_camera_start(Camera001)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力

	--★★トリスタン★★:隣、失礼するよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080016")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor002,"Normal")
	on_cutin(2,Actor001,"Surprise")
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",1)
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",1)
turn_chara(Actor001,65,0.3)
wait_time(2.0)
-- ▲直接出力
	close_cutin()
-- ▼直接出力
set_enable_auto_lookat(Actor003,false)
lookat_weight(Actor003,0.6, 0.03, 0.7, 0.5)
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
-- ▲直接出力

	--★★トリスタン★★:突然だけど<br>継承者クンに質問
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080018")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)

	--★★トリスタン★★:「キミは街の人に頼まれ<br>悪いヤツに誘拐された子供を捜すことになった」
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080019")


	--★★トリスタン★★:「調査の末<br>見事キミは誘拐された子供を見つけた」
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080020")


	--★★トリスタン★★:「ところが、その犯人は<br>キミのよく知る人物だった」
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080021")

	change_face(Actor003,"Sad")

	--★★トリスタン★★:「犯人は、この子供を連れて行かないと<br>自分と家族が殺されてしまう、という」
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080022")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:さて<br>そんなときキミならどうする？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01106_080024","MA_01106_080025","MA_01106_080026")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:子供を助ける…かな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_080029")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:…本当に？
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★トリスタン★★:絆を断ってでも<br>忠実に任務を守るワケだ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080031")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:犯人を見逃してやる…かもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_080033")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:依頼人と子供は見棄てて<br>知り合いの味方をするんだね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080034")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★トリスタン★★:良き赤の他人より、悪しき知り合い<br>いいね、エゴイスティックで好みだよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080035")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:犯人を脅している相手を討つ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_080037")

	change_face(Actor003,"Normal")

	--★★トリスタン★★:その相手が見つかるなら<br>キミにその実力があるなら
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★トリスタン★★:丸く収まりそうだね<br>理想論だけど
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080039")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:早くも休暇が最後とは参るでしょ？<br>夢の学園生活がこんなでさ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080041")

	change_face(Actor002,"Anger")

	--★★ティルフィング★★:せっかくのランチが冷めそうです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","MA_01106_080043")

-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★トリスタン★★:構わず食べてくれればよかったのに<br>行儀がいいね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080045")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★トリスタン★★:リンゴ狩りでキミのボロが出るといいな<br>期待してるよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01106_080047")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101033","001","101033001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_2DOnly_Preload("101032","001","101032001")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
