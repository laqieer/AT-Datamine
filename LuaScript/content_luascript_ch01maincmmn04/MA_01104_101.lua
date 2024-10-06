-- このluaスクリプトは、MA_01104_101.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	Camera003 = SetTemplate("Actor003",92.3,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Nbl_f_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_001)
	Camera005 = SetTemplate("Actor005",92.3,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
 -- キャラ配置
set_pos(Actor003,{-2.913,0,-13.211})
set_pos(Actor005,{-3.69,0,-13.53})
Hide(Actor003)
Hide(Actor005)
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(5,false)
setup_template_moveobj_110122_01(6,false)
setup_template_moveobj_110122_01(7,false)
setup_template_moveobj_110122_01(8,false)
-- ▲直接出力
-- ▼直接出力
FX_DoF = load_postprocess("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
off_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
Ef_0001 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
-- ▲直接出力
-- ▼直接出力
Ef_0002 = load_particle("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101068","001","101068001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor002,"Sad")

	--★★ディナタン★★:現実は厳しいね。兄さん
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010004")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力

	--★★ノワール★★:ディナタン、ひとりで平気か？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010005")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★ディナタン★★:兄さんと一緒の<ruby=クラス>学級</ruby>なら<br>…よかったんだけど
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010006")

-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:<ruby=おれたちみたいな>これまで敵同士だった</ruby>相手を<br>簡単には受け入れてくれないよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010008")

-- ▼直接出力
CloseTalkWindow()
EntryWalk(Actor004,Camera004,EntryData110122_01_01,CameraAssetBundleName110122_01,CameraPos110122_01_101)
-- ▲直接出力
	change_face(Actor004,"Serious")

	--★★ウレリー★★:ねえ。教えてよ
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010011")

-- ▼直接出力
setup_small_camera_start(RndCamera004)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
wait_time(1.3)
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor001,Actor002)
set_common_look_at(Actor002,Actor001)
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ディナタン★★:に、兄さん、お知り合い？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010013")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い…いや──
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010014")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
set_enable_auto_lookat(Actor002, false)
set_common_look_at(Actor001,Actor004)
set_common_look_at(Actor002,Actor004)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★ウレリー★★:ノワールくん。どう考えてるの？<br>貴方についての根も葉もない噂が飛び交ってるよ
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010016")


	--★★ウレリー★★:「ケイ卿に金を積んで円卓の騎士になった」とか<br>「<ruby=あなたたち>あの傭兵兄妹</ruby>はカレドニアのスパイだ」とか
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★ディナタン★★:そ、そんなの、うそです…！
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010020")

	change_face(Actor001,"Normal")

	--★★ノワール★★:…<ruby=あっち>敵側</ruby>にいたのは本当だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010021")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Worry")
	change_face(Actor004,"Serious")

	--★★ウレリー★★:だったら罵られてもしょうがない？
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010023")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ウレリー★★:
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010024")


	--★★ノワール★★:なにが言いたいんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010026")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Anger")
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Surp")

	--★★ウレリー★★:思い知らせてやりたくない！？
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","MA_01104_1010028")

	close_cutin()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:思い知らせる…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010030")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
 --on_camera(CUT_CAMERA1)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_No")

	--★★ウレリー★★:
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010031")

-- ▼直接出力
 --on_camera(CUT_CAMERA2)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Angry")

	--★★ウレリー★★:デマやゴシップを鵜呑みにする情報弱者どもに<br>貴方の待遇が誤りではないことを！！
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01104_1010034","MA_01104_1010035","MA_01104_1010036")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…思い知らせてやりたいよ<br>できることなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010038")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Anger")

	--★★ウレリー★★:現実に立ち向かおうという意志はないの！？<br>貴方の熱意はどこ行ったのよ！
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010039")

	change_face(Actor001,"Sad")

	--★★ノワール★★:この人スゴイな勢いが
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010040")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…思い知らせてやりたいよ<br>できることなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010042")

	change_face(Actor001,"Anger")

	--★★ノワール★★:お情けで円卓の騎士にさせられた<br>なんて思われたくない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010043")

	PlayAction(Actor004,"to  Std_Surp")
	change_face(Actor004,"Smile")

	--★★ウレリー★★:そうでしょ！？そうだよ！！<br>現実に立ち向かってこそ青春だよ！
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010044")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01104_1010046")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ディナタン★★:わ、私は…私も兄さんが悪く言われるのはイヤ<br>それに私自身もこのままなんて、イヤ…だな
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010047")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★ウレリー★★:妹さんは意外ときっぱりしててイイね！<br>ノワールくんはもっと主体性を持ちなよ！
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010048")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera002)
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
Appear(Actor003)
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
PlayActionDirect(Actor005,"to Wlk")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003,{-0.273,0,-13.32},2.6)
slidemove(Actor005,{-1.05,0,-13.64},2.6)
-- ▲直接出力
-- ▼直接出力
wait_time(2.6)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Wlk")
PlayActionDirect(Actor005,"to Wlk")
turn_chara(Actor003,37.6,0.32)
turn_chara(Actor005,28,0.32)
wait_time(0.32)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor005,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
	change_face(Actor003,"Laugh")

	--★★ギネヴィア★★:生徒会長代理<br>転校生クンのお世話もほどほどに
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_1010051")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ウレリー★★:
	Talk(Actor004,"CHRNAME_NAMELES","speech","L","MA_01104_1010053")

	PlayAction(Actor003,"to  Std_Joy")
	change_face(Actor003,"Smile")

	--★★ギネヴィア★★:にっしっしっし…♪
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_1010054")

	change_face(Actor002,"Surprise")

	--★★ディナタン★★:生徒会長代理…？
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010055")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
manager.CloseupUpExclusiveCamera(Actor004)
DontChangeRandomCamera(true)
-- ▲直接出力
-- ▼直接出力
--ウレリー,CHRNAME_URRIE @名前変更
-- ▲直接出力
	PlayAction(Actor004,"to Bow")
	change_face(Actor004,"Normal")

	--★★ウレリー★★:教えてあげる<br>ワタシは生徒会長代理のウレリー
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010057")

-- ▼直接出力
CloseTalkWindow()
wait_time(1.1)
-- ▲直接出力
-- ▼直接出力
OpenFirstAppearance(Actor004)
DontChangeRandomCamera(false)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ウレリー★★:
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010058")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Smile")

	--★★ウレリー★★:教えてあげる
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010059")


	--★★ディナタン★★:この学園で何を学べるのか、ちょっとずつ<br>明日から。顔を合わせるたびにネチネチとね
	Talk(Actor002,"CHRNAME_DINATAN","speech","L","MA_01104_1010060")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Normal")

	--★★ウレリー★★:
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010061")

	change_face(Actor004,"Smile")

	--★★ウレリー★★:
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010062")


	--★★ディナタン★★:
	Talk(Actor002,"CHRNAME_DINATAN","mind","L","MA_01104_1010063")

-- ▼直接出力
CameraEX = set_camera({-0.421, 1.04, -12.309,   348.72, 138.5, 346.61,25})
set_camera_nearclip(CameraEX,1.05)
setup_small_camera_start(CameraEX)
on_parent(Ef_0001, CameraEX, "", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
on_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
change_face(Actor004,"Anger")
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to  Std_Angry")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
wait_time(1.1)
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ウレリー★★:学力！体力！精神力！<br>培う学び舎キャメロット！
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010065")

-- ▼直接出力
CameraEX2 = set_camera({0.86, 1.328, -12.596,   352.3, 205.3, 13.09999,   25})
setup_small_camera_start(CameraEX2)
on_parent(Ef_0002, CameraEX2, "", 0.0, 0.0, 0.0, 0.0, 0.0, 0.0)
-- ▲直接出力

	--★★ウレリー★★:学んで立てよう己の身！<br>これがワタシの座右の銘！
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010066")

-- ▼直接出力
off_active(FX_DoF)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Surp")
	change_face(Actor003,"Surprise")

	--★★ギネヴィア★★:ワァびっくりしたぁ<br>いきなり声大きいなぁもぉ
	Talk(Actor003,"CHRNAME_GUINEVERE","speech","L","MA_01104_1010067")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor004,"to Std_Loop")
set_enable_auto_lookat(Actor004, false)
lookat_delay_weight(Actor004, 1.2, 0.8, 1.0, 1.0,1.0)
keep_delay_ik_lookat(Actor004, ノワール, "J_Head",1.0)
wait_time(1.1)
-- ▲直接出力
	change_face(Actor004,"Serious")

	--★★ウレリー★★:勘違いしないでよ、ノワールくん<br>これはワタシのポリシーの問題なんだから
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010069")

-- ▼直接出力
setup_small_camera_start(Camera004)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor004,"to  Std_Sad02")
-- ▲直接出力
-- ▼直接出力
wait_time(0.7)
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ウレリー★★:キライなんだよ<br>根も葉もない噂なんて
	Talk(Actor004,"CHRNAME_URRIE","speech","L","MA_01104_1010071")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_postprocess_preload("content_adv_postprocess_depthoffield", "Ef_C_PP_DepthOfField", false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
load_particle_preload("content_effect3d_common_adv", "Ef_C_Adv_ELine_Radial01_Lop", false, false)
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101068","001","101068001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
