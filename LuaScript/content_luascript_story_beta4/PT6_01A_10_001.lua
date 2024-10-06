-- このluaスクリプトは、PT6_01A_10_001.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",324.2681,CharaPos110122_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
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
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:ギネマウアさん<br>今日はギネヴィアと一緒じゃないんですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010006")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_delay_weight(Actor002, {1.1, 0, 0.5, 0.2} ,1.0)
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:はい。今日は学園祭準備のときにできた友達と<br>食事をするそうで
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010007")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ！<br>それはよかった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010008")

-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:ノワール様、立ち話もなんですし<br>よろしければお座りください
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010009")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0, FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,true)
-- ▲直接出力
-- ▼直接出力
set_animationcontroller(Actor001, "Com_m_SitController", "to Sit01_Loop")
-- ▲直接出力
-- ▼直接出力
Camera001 = setup_small_camera_resetting(Actor001,CharaPos003,CameraPos003)
-- ▲直接出力
-- ▼直接出力
lookat_delay_weight_reset(Actor002 , 1)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
-- ▼直接出力
wait_time(TIME_ELAPSED)
-- ▲直接出力
-- ▼直接出力
fadein(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
wait_time(FADE_TIME)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こうやって向かい合って話をするのって<br>ひょっとして初めてかも？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:言われてみれば、そうかもしれませんね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010011")


	--★★ギネマウア★★:ただ、あの子とあなたが<ruby=ゲシュタルト・シフト>ＧＳ</ruby>したあとから<br>私はあなたの存在を感じることがありますよ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010012")

	open_select_window_tag(Actor001,"Normal","PT6_01A_10_0010013","PT6_01A_10_0010014")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それはなんだか恥ずかしいな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010016")

-- ▼直接出力
PlayPartVoice("ギネマウア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:恥ずかしい…？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010017")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ああっ、いや！違う！違うんだ！<br>そうじゃなくて！誤解です！すみません！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010018")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:まだ、なにも申し上げておりませんが…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:嬉しいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010021")

-- ▼直接出力
PlayPartVoice("ギネマウア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネマウア★★:嬉しい、ですか…？<br>それはどういう意味でしょう？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:マスターとキラーズがお互いを感じとれるのって<br>絆とか信頼から来ると思うんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010023")

	change_face(Actor001,"Smile")

	--★★ノワール★★:たとえ薄っすらとでも<br>ギネマウアさんが俺を感じてくれているなら
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010024")

	change_face(Actor001,"Smile")

	--★★ノワール★★:ギネマウアさんと俺とのあいだに<br>信頼関係が築けたのかなって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010025")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:ノワール様…
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ギネマウア", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:もちろん<br>信頼しておりますよ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010027")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:そうだ<br>たまにはあの子も食事に誘ってあげてくださいね
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:気付くと<br>ひとりぼっちで食べていることが多いんです
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","PT6_01A_10_0010030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:わかりました<br>見かけたら、声をかけるようにします
	Talk(Actor001,"CHRNAME_NOIR","speech","L","PT6_01A_10_0010031")

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
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
