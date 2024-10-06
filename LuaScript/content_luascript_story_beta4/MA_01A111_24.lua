-- このluaスクリプトは、MA_01A111_24.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_01","110901_01_h")
Include("content_adv_advsmall_110901_01","Template110901_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110901_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110901_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName110901_01,CameraPos110901_01_006)
	InitializeTemplateRandomCamera110901_01()
	InitializeTemplate110901_01()
-- ▼直接出力
load_image("10103034", "content_still_10103034_image", "101030340_StillImage")
prop001 = setup_prop_object(10106003)
set_pos(prop001 , {0.383,0.507,-0.277})
-- ▲直接出力
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1)
-- ▲直接出力
-- ▼直接出力
set_pos(Actor001,{-0.783, 0, -0.347})
-- ▲直接出力
-- ▼直接出力
 lookat_weight(Actor001,0.8, 0.08, 0.7, 0.6)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110901)
	Actor001 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "挨拶")
-- ▲直接出力

	--★★ギネヴィア★★:お姉ちゃんって～<br>もしわたしがいなくなってもさ、生きていける？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240002")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:どういう質問？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:わたしが恋しくて泣いちゃう？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240006")

	PlayAction(Actor002,"to  Std_No")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ギネマウア★★:泣きません<br>妹離れはできてますから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240008")

	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力

	--★★ギネヴィア★★:にっしっし…♪
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ギネマウア★★:お手紙の中身が見えてしまうわ<br>文通内容は秘密にしたほうがいいんじゃない？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ああそうか、そうね<br>なんかそういうの楽しいね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240012")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネマウア★★:ふふ…私は楽しそうなあなたを見るのが楽しい
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240013")


	--★★ギネヴィア★★:でもねお姉ちゃん<br>エレインへのお返事で悩んでることがあって
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240014")

	change_face(Actor002,"Normal")

	--★★ギネマウア★★:なあに？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240015")

-- ▼直接出力
setup_small_camera_end()
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:第１問
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240016")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:キラーズとして戦い続けるということは<br>自分の記憶や存在を消耗し続けてるってことよね
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240017")


	--★★ギネヴィア★★:自分の記憶が失われていったり<br>そういうことはある？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240018")


	--★★ギネヴィア★★:お姉ちゃんはどう？<br>記憶が薄れていっていたりしない？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240019")

-- ▼直接出力
 --PlayPartVoice("ギネマウア", "肯定2")
-- ▲直接出力

	--★★ギネマウア★★:あなたのバイブスが<br>私の記憶を繋ぎ留めてくれているのよ？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240020")


	--★★ギネマウア★★:さらにあなたが<ruby=ノワール>継承者</ruby>様と<ruby=ゲシュタルト・シフト>ＧＳ</ruby>したことで<br>私は彼のバイブスとも結びつくことができた
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240021")


	--★★ギネマウア★★:あなたと継承者様の選択が<br>いまの私の記憶と存在を守ってくれている
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネマウア★★:生まれてから今までの想い出が<br>綺麗に残っているわ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:だよね。よかった
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240026")


	--★★ギネマウア★★:ギネヴィア…？
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:ノワールのバイブスと<br>お姉ちゃんのキラーズが繋がっていれば…
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:もしわたしがいなくなっても<br>お姉ちゃんは生きていけるんだよね？
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ギネヴィア★★:「ギネヴィアさんへ」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240032")


	--★★ギネヴィア★★:「ギネヴィアさんって幼いころは<br>どんな子供だったんでしょうか、気になります」
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240033")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ギネヴィア★★:アストラットの美姫<br>エレインさんからのお手紙でした
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネヴィア★★:さて、ここで第２問
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240035")

	PlayAction(Actor002,"to  Std_No")
	change_face(Actor002,"Sad")

	--★★ギネマウア★★:…ギネヴィアいいのよ、わかったわ<br>もういいの、もういいのよ
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240037")


	--★★ギネマウア★★:私が覚えてる、私が全部聞かせてあげるから
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240039")


	--★★ギネヴィア★★:第２問
	Talk(Actor001,"CHRNAME_GUINEVERE","speech","L","MA_01A111_240040")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("ギネマウア", "苦しみ")
-- ▲直接出力

	--★★ギネマウア★★:ギネヴィア！
	Talk(Actor002,"CHRNAME_GWENHWYMAWR","speech","L","MA_01A111_240041")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10103034", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
voiceSignalS = voice_play("VO_MA_01A111_240042")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
 --wait_time(3.5)
fadeout(0,0,0,1.0,2.0)
wait_time(2.5)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("10103034", "content_still_10103034_image", "101030340_StillImage")
setup_prop_object_preload(10106003)
	InitializeLoad_Preload()
	load_area_scene_preload(110901)
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
