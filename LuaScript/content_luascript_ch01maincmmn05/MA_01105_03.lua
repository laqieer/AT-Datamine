-- このluaスクリプトは、MA_01105_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-55,CharaPos112021_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_003)
	Camera002 = SetTemplate("Actor002",95,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
hotdog = setup_prop_object(10102001)
-- ▲直接出力
-- ▼直接出力
hotdog_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(hotdog,Actor001, "Loc_weapon_constrint_R", hotdog_offset)
-- ▲直接出力
-- ▼直接出力
hotdog2 = setup_prop_object(10102001)
off_active(hotdog2)
-- ▲直接出力
-- ▼直接出力
hotdog2_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(hotdog2,Actor002, "Loc_weapon_constrint_R", hotdog2_offset)
off_parent(hotdog2)
-- ▲直接出力
-- ▼直接出力
SkipDefaultMotion(Actor001)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to EatIdle")
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:食べづら…！<br>かぶりつくのコレ…！？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030002")

	change_face(Actor002,"Surprise")

	--★★ノワール★★:意外だな。ログレスはもっと<br>上品な食べ物が並んでるのかと思った
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ウチの王様のシュミなのよ<br>この手のジャンクな食べ物は
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030004")


	--★★ノワール★★:食べたことないのか？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030005")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ギネヴィア★★:彼に歩み寄る気はさらさらないワケ<br>わたしが喜んで食べると思う？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030006")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:ハァ、食べづら…！雑多な盛りつけして…！<br>ソースが溢れて服につくじゃない！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:つかないように食べるんだよ<br>そんな難しい？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030009")

	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:ハァーッ！？ハァッ！？何それ！煽ってんの！？<br>余裕よそんなこと！甘くみないでよっ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Surprise")

	--★★ギネヴィア★★:きゃあぁっ、ソース出てきたっ<br>ほんと食べづら！ちょ、制服についた～っ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","N","MA_01105_030012")

	close_cutin()
	open_select_window_tag(Actor002,"Normal","MA_01105_030014","MA_01105_030015")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★ノワール★★:…ふふっ
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030017")

	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:笑うな！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030018")

	change_face(Actor001,"Anger")

	--★★ギネヴィア★★:笑うな！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030019")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayActionDirect(Actor002,"to  Std_Talk")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:ちょっと、やめ、なに、近い近い<br>ひゃっ、触んないでよ、ちょーっとおお…っ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030021")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Surprise")

	--★★ノワール★★:早く拭かないとシミになっちゃうから
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030022")

	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:あっ、そういう、こと…？<br>で、でも自分でやるからっっ！！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030023")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:あなた、食べてみなさいよ！<br>絶対こぼすから！やってみなさいよ！今！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030025")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
setup_small_camera_start(RndCamera008)
on_active(hotdog2) 
on_parent(hotdog2,Actor002, "Loc_weapon_constrint_R", hotdog2_offset)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to EatIdle")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネヴィア★★:えっ、すご…どうやってるの
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ノワール★★:こう…吸いながら、すくうようにして…
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030028")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to EatIdle")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:おっ、お～～～っ！<br>ほんとね、きれいに食べられたわ！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:ていうかすっごい美味しいんだけど…<br>なんでわたし、今まで食べなかったんだろ…！
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01105_030031")

-- ▼直接出力
 --setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ノワール★★:…食べづらいから？
	Talk(Actor002,"CHRNAME_NOIR","speech","L","MA_01105_030032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
setup_prop_object_preload(10102001)
hotdog_offset = {0,0,0,0,0,0}
setup_prop_object_preload(10102001)
hotdog2_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
