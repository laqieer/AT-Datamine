-- このluaスクリプトは、CO_101025_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114051_01","114051_01_h")
Include("content_adv_advsmall_114051_01","Template114051_01_h")
Include("content_adv_advsmall_114051_01","114051_01_h")
Include("content_adv_advsmall_114051_01","Template114051_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114051_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_001)
	Camera005 = SetTemplate("Actor005",nil,CharaPos114051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_004)
	Camera006 = SetTemplate("Actor006",nil,CharaPos114051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_005)
	Camera007 = SetTemplate("Actor007",nil,CharaPos114051_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Emy_001_00_Controller","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_008)
	InitializeTemplateRandomCamera114051_01()
	InitializeTemplate114051_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image("104000040", "content_still_10400004_image", "104000040_StillImage")
set_camera_nearclip(Camera003,2)
set_pos(Actor002,{-0.55,0.3,-7.3})
set_rot(Actor002,{0,0,0})
set_pos(Actor003,{-1.8,0,7.1})
set_pos(Actor005,{-0.8,0,4})
set_rot(Actor005,{0,180,0})
set_pos(Actor006,{1,0,5})
set_rot(Actor006,{0,180,0})
set_pos(Actor007,{0,0,3})
set_rot(Actor007,{0,180,0})
set_animationbattlecontroller(Actor004,1,false)
PlayActionDirect(Actor004,"ToAbnormal")
Hide(Actor003)
Hide(Actor004)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end
function template2()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114051_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114051_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_515_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114051_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_010_01_StdController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114051_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SleepController","to Std_Loop",CameraAssetBundleName114051_01,CameraPos114051_01_002)
	InitializeTemplateRandomCamera114051_01()
	InitializeTemplate114051_01()
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Reconnaissance")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Area_Acoustic")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114051)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401042","001","401042001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	Actor008 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
setup_small_camera_start(Camera001)
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:この森の奥に<br>例の教団のアジトがあるのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030002")

-- ▼直接出力
CloseTalkWindow()
Appear(Actor003)
 PlayActionDirect(Actor003,"to Wlk")
 slidemove(Actor003,{-1,0,7.1},0.5)
wait_time(0.3)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor005)
Appear(Actor006)
Appear(Actor007)
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力

	--★★ヴォールス★★:おそらくな<br>まだ合流していなければいいのだが
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030003")

-- ▼直接出力
bgm_play("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
setup_small_camera_start(RndCamera002)
wait_time(0.1)
PlayActionDirect(Actor002,"to Std_Loop")
Hide(Actor001)
Hide(Actor003)
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:ふたりとも、止まって
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030004")

-- ▼直接出力
setup_small_camera_start()
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:バルバロイ！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030006")

-- ▼直接出力
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ヴォールス★★:クレア、これは…
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030007")


	--★★クレア★★:………
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030008")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor002)
Hide(Actor005)
Hide(Actor006)
Hide(Actor007)
Appear(Actor004)
setup_small_camera_start(RndCamera004)
wait_time(TIME_ELAPSED)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民中年_男2", "苦しみ")
-- ▲直接出力

	--★★市民（中年男）③★★:ハァ、ハァ…
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030010")


	--★★市民（中年男）③★★:犬に噛まれたキズが思いのほか深くて<br>歩いてくるのに手間取っちまったが
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030011")

-- ▼直接出力
PlayActionDirect(Actor004,"ToIdle")
-- ▲直接出力

	--★★市民（中年男）③★★:もう少しで教団のアジトだ
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★市民（中年男）③★★:計画は失敗しちまったけど<br>まだすべてが終わったわけじゃねえ
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030013")


	--★★市民（中年男）③★★:「俺は連続殺人鬼『血の蒐集家』だ<br>怒らせたらどうなるかわかってるだろう？」
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030014")


	--★★市民（中年男）③★★:…とでも言ってヤツらを脅して<br>魔力を手に入れればこっちのもんだ
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030015")


	--★★？？？★★:ほう<br>怒らせたらどうなるんだ？
	Talk(Actor008,"CHRNAME_NAMELES","speech","N","CO_101025_09030016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民中年_男2", "驚き")
-- ▲直接出力

	--★★市民（中年男）③★★:え？
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030017")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, 0.2,false,false)
set_scale_image(20,20)
wait_time(0.5)
-- ▲直接出力
-- ▼直接出力
Appear(Actor001)
Appear(Actor002)
Appear(Actor003)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
PlayActionDirect(Actor003,"to Std_Loop")
change_face(Actor001,"Sad")
change_face(Actor002,"Sad")
change_face(Actor003,"Sad")
template2()
set_rot(Actor001,{0,-170,0})
set_rot(Actor002,{0,130,0})
Hide(Actor004)
lookoj=create_object("kara")
set_pos_object(lookoj,0.5,0,8.7)
keep_delay_ik_lookat_object(Actor001,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor002,lookoj,"kara",1.0)
keep_delay_ik_lookat_object(Actor003,lookoj,"kara",1.0)
lookat_weight(Actor001,0.5,0.03,0.7,0)
lookat_weight(Actor002,0.5,0.03,0.7,0)
lookat_weight(Actor003,0.5,0.03,0.7,0)
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★市民（中年男）③★★:う、うわああああああああ！！
	Talk(Actor004,"NPCNAME_0242","speech","N","CO_101025_09030019")

-- ▼直接出力
se_play("SE_ADV_CO_101025_0903_GoreSlash_Kill")
wait_time(1.0)
CloseTalkWindow()
wait_time(0.2)
se_play("SE_ADV_CO_101025_0903_GoreBodyfall")
wait_time(2)
hide_image(1)
wait_time(1)
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_ADV_Reconnaissance")
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うっ！？<br>こ、これは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030022")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:やはり…<br>血の蒐集家の怒りを買ってしまったわね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030023")

-- ▼直接出力
set_enable_auto_lookat(Actor002,true)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
keep_delay_ik_lookat(Actor003,Actor002,"J_Head",1)
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:本物のってことか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:ええ<br>間違いないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030025")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "怒り")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:ひどい殺されかただ
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030026")

	PlayAction(Actor003,"to  Std_Worry")

	--★★ヴォールス★★:「忘れたほうが良かったと思えるくらい<br>悲劇の記憶を刻んでやる」か
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101025_09030029","CO_101025_09030030")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:忘れたほうが良かった記憶って<br>悲劇だけなんだろうか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030032")

-- ▼直接出力
PlayPartVoice("クレア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★クレア★★:どういうこと？
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030033")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ジャスパーにしてみれば<br>幸せだった頃の記憶を忘れられれば
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030034")

	change_face(Actor001,"Sad")

	--★★ノワール★★:こんなことには<br>ならずに済んだかもなってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クレア★★:そうね<br>そうかもしれない。けれど…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030036")

	change_face(Actor002,"Normal")

	--★★クレア★★:守りたい記憶があるから強くなれる<br>…そんなこともあると思うわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030037")

-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:クレア…
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030039")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ジャスパーは家族も知り合いも<br>いなかったと聞いた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030041")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Sad")

	--★★ノワール★★:じゃあ、血の蒐集家は<br>ジャスパーのこの姿を誰に見せたかったんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030042")

	change_face(Actor002,"Sad")

	--★★クレア★★:…
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030044")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("クレア", "否定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:血が乾ききっていない<br>あいつはまだこのあたりにいる
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030046")

	PlayAction(Actor003,"to  Std_Surp")
-- ▼直接出力
change_face(Actor001,"Surprise")
PlayPartVoice("ヴォールス", "驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ヴォールス★★:今から追うつもりか？
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("クレア", "肯定3")
-- ▲直接出力

	--★★クレア★★:お爺ちゃんの仇がすぐそばにいるの<br>逃がすわけにはいかないわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030048")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:…と言いたいところなのだけれど<br>今回はやめておいたほうがよさそうね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030049")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いいのか？<br>ずっと探していた仇なのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030050")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力

	--★★クレア★★:もちろん、できることなら<br>今すぐ追いかけたいところだけど
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030051")

	change_face(Actor002,"Anger")

	--★★クレア★★:わたしたちはこれまで<br>不審な襲撃を二度も受けている
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030052")

	change_face(Actor002,"Normal")

	--★★クレア★★:恐らく、これは警告だと思うわ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030053")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:警告？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030054")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:まだ雌雄を決するには早い<br>そういうことよ、きっと
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030055")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:なるほど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030056")

-- ▼直接出力
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ヴォールス", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ヴォールス★★:成長したな、クレア
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030057")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
-- ▲直接出力

	--★★ヴォールス★★:少し前までのお前なら<br>制止の声も聞かずに走り出していただろう
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030058")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("クレア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クレア★★:そうかしら<br>頼りになる助手たちに感謝しないとね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030059")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(true)
set_common_look_at(Actor003,Actor001)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:ところでノワール<br>その手に持っているものは？
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030061")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,160,0.5)
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ、そうだった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030062")

-- ▼直接出力
ShowImageItem("104000040")
-- ▲直接出力

	--★★ノワール★★:ジャスパーの遺体のそばの木に<br>こんなメッセージカードが貼ってあった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030064")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:「まがいものを見つけ出してくれたことに感謝<br>２代目名探偵とまみえる日を楽しみにしている」
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030066")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
SkipDefaultMotion(Actor003)
PlayActionDirect(Actor003,"to  Std_Worry")
PlayPartVoice("ヴォールス", "悩む")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ヴォールス★★:感謝状？<br>…いや挑戦状か
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030067")

	open_select_window_tag(Actor001,"Normal","CO_101025_09030069","CO_101025_09030070")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,-150,0.5)
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:受けて立たないとな、２代目名探偵さん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030072")

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:助手のひとりとして<br>もちろん俺も協力させてもらう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030073")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
set_enable_auto_lookat_all(true)
PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ふふっ<br>期待しているわよ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030074")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ヴォールス", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ヴォールス★★:自分は助手ではないと言ったはずだが…
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030075")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
PlayActionDirect(Actor001,"to  Std_Talk")
turn_chara(Actor001,-150,0.5)
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:血の蒐集家とやり合うんだな<br>応援するよ、頑張ってくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101025_09030077")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
set_enable_auto_lookat_all(true)
PlayPartVoice("クレア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★クレア★★:…負けるつもりはないわ<br>お爺ちゃんのためにもね
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030078")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat_all(false)
PlayPartVoice("ヴォールス", "肯定")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ヴォールス★★:どんな相手が現れても自分が守ってやる<br>安心しろ、クレア
	Talk(Actor003,"CHRNAME_BORS","speech","L","CO_101025_09030079")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start(RndCamera001)
change_face(Actor001,"Normal")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クレア★★:さて、ふたりともお疲れさま<br>これで一件落着よ
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030081")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Greet_one")
-- ▼直接出力
PlayPartVoice("クレア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クレア★★:ログレスに戻りましょう
	Talk(Actor002,"CHRNAME_CLARE","speech","L","CO_101025_09030082")

-- ▼直接出力
local trustParam = set_communication_rankup("クレア_コミュランク", "クレア_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
load_image_preload("104000040", "content_still_10400004_image", "104000040_StillImage")
preload_sound("BGM_ADV_Invasion2")
preload_sound("BGM_ADV_Reconnaissance")
preload_sound("BGM_Area_Acoustic")
	InitializeLoad_Preload()
	load_area_scene_preload(114051)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101025","001","101025001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101024","001","101024001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401042","001","401042001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("201001","001","201001001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114051_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
