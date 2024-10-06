-- このluaスクリプトは、EA_001_041.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",195,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_505_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera002 = SetTemplate("Actor002",223,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera003 = SetTemplate("Actor003",228,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",310,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera005 = SetTemplate("Actor005",54,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera006 = SetTemplate("Actor006",355,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera007 = SetTemplate("Actor007",38,CharaPos110111_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_008)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
set_pos(Actor002,{0.158,0,2.552})
Hide(Actor002)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor003,{-0.069,0,3.503})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor005,{-3.893,0,0.467})
keep_ik_lookat(Actor005,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-2.345,0,-0.62})
keep_ik_lookat(Actor006,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor007,{-3.207,0,-0.185})
keep_ik_lookat(Actor007,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_Battle_Rgnl")
-- ▲直接出力
-- ▼直接出力
CameraEx_01 = set_camera({-4.32, 6.635, 4.052,   350, 159.6, 0,   35})
-- ▲直接出力
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
show_image("101010140", 0.0, 0.0, 0,false,false)
set_scale_image(20,20)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101019","001","101019001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401035","001","401035001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor006")
	Actor007 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor007")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(CameraEx_01)
hide_image(1.0)
wait_time(3.0)
slidemove2(CameraEx_01,-4.32,1.19,4.052,6.8,3)
turn(CameraEx_01,{2, 159.6, 0},7.0)
wait_time(8.0)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("イゾルデ","挨拶")
-- ▲直接出力

	--★★イゾルデ★★:朝は弱いの<br>目が覚めるような輝きを見せなさい
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041002")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor002)
Appear(Actor003)
PlayActionDirect(Actor002,"to Wlk")
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor002,-0.95,0,1.464,1.5)
wait_time(0.3)
slidemove(Actor003,-1.36,0,2.241,1.5)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.5)
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,54,0.5)
wait_time(0.2)
PlayActionDirect(Actor004,"to Wlk")
turn_chara(Actor004,22,0.3)
wait_time(0.3)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(0.2)
turn_chara(Actor002,250,0.25)
wait_time(0.25)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.05)
PlayActionDirect(Actor003,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ラグネル","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:あっはっはっはっは
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041004")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラグネル","肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:あたしはね<br>朝が一番冴えてる
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041005")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor003,"Normal","EA_001_041007","EA_001_041008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
keep_delay_ik_lookat(Actor003,Actor001,"J_Head",1.0)
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:イゾルデ、なんのつもりだ？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_041010")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
lookat_delay_weight(Actor002,0.5,0.1,0.85,0.2,1.0)
PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★イゾルデ★★:ラグネルから聞いてなくて？<br>彼女に頼み込まれたのよ
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041011")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:リベンジ！それだけっ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041012")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor003,"J_Head",0.8)
wait_time(0.2)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:ラグネル、結局プランＣって？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_041014")

	PlayAction(Actor002,"to Finger")
-- ▼直接出力
lookat_delay_weight(Actor002,0.5,0.1,0.85,0.2,1.0)
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:プランＢの次
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041015")

-- ▼直接出力
PlayPartVoice("ノワール","落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ノワール★★:だから、Ｃは？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_041016")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:だからプランBの次だってば
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041017")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ラグネル","肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:君はいいやつだよね、ノワール<br>ガウェインが言ってたとーりだよ
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041019")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ラグネル★★:手芸サークル入ってくれたり<br>いろいろ付き合ってくれて、今日も早起きで
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041020")

-- ▼直接出力
PlayPartVoice("ラグネル","喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ラグネル★★:なんでもしてくれるじゃん<br>器がデカいね
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール","照れ")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ノワール★★:なんでもはしないぞ<br>早起きはつらかったし
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_041022")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ラグネル","肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ラグネル★★:君の憧れの大きさが<br>わかってきた気がする
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041023")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")

	--★★ラグネル★★:あたしも…小さい頃はあった気がする<br>こうなりたい、こんなことしてあげたいってのが
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041024")

-- ▼直接出力
PlayPartVoice("ラグネル","笑い")
-- ▲直接出力

	--★★ラグネル★★:いまはちょっと恥ずかしくなっちゃって<br>大声でごまかすようになってたのかもしれない
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041025")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
lookat_delay_weight_reset(Actor002,1.0)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
wait_time(2.0)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ラグネル★★:こんがらかってたみたい、ちょっとだけね
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力

	--★★ノワール★★:…ラグネル？
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_001_041027")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
change_face(Actor002,"Normal")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
bgm_play("BGM_Battle_Rgnl")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("イゾルデ","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★イゾルデ★★:五月祭は明日。これが騒ぎになるか祭りになるか<br>それはお前たち次第よ
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041028")


	--★★イゾルデ★★:私がかき集めたログレス兵たち<br>彼らの望みはそれぞれ
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041029")

-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力

	--★★イゾルデ★★:<ruby=ギネヴィア>王妃様</ruby>のお家騒動に巻き込まれたくない者<br>最近のバルバロイ騒ぎで及び腰になっている者
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("イゾルデ","0013")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★イゾルデ★★:<ruby=カワイイ>アップリケ</ruby>を押し付けられて気を害した者
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041032")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("兵士1","0002")
-- ▲直接出力

	--★★キャメロット軍兵士_上位★★:ウップン晴らしに<br>付き合ってもらいてェな、オォ？
	Talk(Actor004,"NPCNAME_0124","speech","N","EA_001_041033")

	change_face(Actor001,"Normal")

	--★★イゾルデ★★:突然の<ruby=ノワール>新入り円卓の騎士</ruby>の力量を計りたい者
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ラグネル★★:それ、イゾルデちゃんもじゃん
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041035")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("イゾルデ","笑い")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★イゾルデ★★:<ruby=わたくし>ナデナデで気を害した者</ruby>
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041037")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ラグネル","驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ラグネル★★:それイゾルデちゃんじゃん！
	Talk(Actor002,"CHRNAME_RAGNAR","speech","L","EA_001_041038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("イゾルデ","肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★イゾルデ★★:ノワールの転入とラグネルの破天荒で<br>こんがらかったこれらの糸…どうすべきかしら
	Talk(Actor001,"CHRNAME_ISOLDE","speech","L","EA_001_041040")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Battle_Rgnl")
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101019","001","101019001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401035","001","401035001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor006")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor007")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
