-- このluaスクリプトは、EA_009_023.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110901_02","110901_02_h")
Include("content_adv_advsmall_110901_02","Template110901_02_h")
-- ▼直接出力
Include("content_adv_advsmall_110901_01","110901_01_h")
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-140,CharaPos110901_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_501_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_006)
	Camera002 = SetTemplate("Actor002",50,CharaPos110901_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110901_02_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110901_02,CameraPos110901_02_007)
	InitializeTemplateRandomCamera110901_02()
	InitializeTemplate110901_02()
-- ▼直接出力
load_sound("VO_story01")
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
load_image("103010130", "content_still_10301013_image", "103010130_StillImage")
-- ▲直接出力
-- ▼直接出力
CameraEX = set_camera({-3.112,1.345,2.963,0,257.574,0,20})
Camera002 = manager.RegisterExclusiveCamera(CameraEX, Actor002)
Camera003 = InitializeCharaCamera(CameraAssetBundleName110901_01, CameraPos110901_01_006, Actor003)
set_camera_nearclip(CameraEX,0.1)
-- ▲直接出力
-- ▼直接出力
Hide(Actor003)
INIT_CHRPOS(Actor003,{3.14,0.011,-1.03,-69},false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115911)
	Actor001 = InitializeCharacter_3D("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0038")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:だから私…とにかくなにかしたいんです
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230004")

-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0009")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:なにか…ですか
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230005")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:今、学園内の空気がちょっと暗いじゃないですか<br>年が明けてもそれを引きずるのは嫌だなって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ディナタン★★:兄さんもなんだか様子が変だし<br>それに…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230007")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0025")
-- ▲直接出力

	--★★ディナタン★★:…それに、ギネヴィアさんも――
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230008")

	change_face(Actor002,"Sad")

	--★★エレイン★★:………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230010")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0049")
-- ▲直接出力

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230011")


	--★★ディナタン★★:私が知らないだけで、もっと<br>大変なことが起こっているのかもしれない
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230012")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0019")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:でも、せめて年が明けて…新しい年には<br>皆に笑顔でいてほしい
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ディナタン★★:兄さん…ギネヴィアさんに<br>前みたいにたくさん笑ってほしいの
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230014")

	change_face(Actor002,"Normal")

	--★★エレイン★★:………
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230015")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0042")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:それで私…エレインさんに相談したくて！<br>学園の皆を励ますためになにかできないかなって
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230016")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:わ、私にですか？<br>どうして…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:だってエレインさんは学園祭を提案して<br>大成功に導いたじゃないですか！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230018")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:あのときも皆すごく大変な時期だったけど<br>あれをきっかけに盛り上がって、笑顔になって…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230019")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0026")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:皆がまた気持ちをひとつに出来たから――<br>あのときみたいに、皆を笑顔にしたいんです！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230020")


	--★★エレイン★★:ディナタンさん…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230021")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0013")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:でも、どうしたらいいんだろう…<br>年明けまでもうちょっとしかないし
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:学園祭をイチから企画するのは<br>さすがに時間が足りないですよね…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン_006","0049")
-- ▲直接出力

	--★★ディナタン★★:それに、せっかくだから新年っぽいイベントで<br>皆の気分を上げられたらって思うんですけど…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230024")

-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0034")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:新年っぽいイベント、ですか…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230025")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:そういえば、私の故郷では年が明けた日に<br>皆で教会に集まって合唱をする風習があるんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230027")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:合唱？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230028")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい。「その年が幸せな一年になりますように」<br>って、皆で想いを込めて歌を歌うんです
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230029")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0048")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★エレイン★★:一緒に歌うと皆の心がひとつになったような<br>そんな気がして…好きなイベントだったなぁって
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0046")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:素敵ですね。合唱かあ…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230031")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ディナタン★★:うん。いいかもしれない！<br>なんだか楽しそうだし…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ディナタン★★:それに、ギネヴィアさんも<br>歌を聞くのが好きだって言ってたし！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230033")

	change_face(Actor002,"Surprise")

	--★★エレイン★★:そういえば…学園祭のイベントを考えてたとき<br>そんなことを言っていましたね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:自分で歌ったり演奏するのはキライだけど<br>音楽鑑賞は好きだって…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230035")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0009")
-- ▲直接出力

	--★★ディナタン★★:なら、皆の合唱を聞いてもらえたら<br>元気が出るかも！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230036")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0034")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エレイン★★:でもいきなり合唱イベントを開催して<br>皆、集まってくれますかね…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230037")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:うーん、それは…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230038")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0002")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エレイン★★:…あ、そうだ！ディナタンさんのステージを<br>メインイベントにするのはどうでしょうか！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230039")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ディナタン★★:ええ！？わ、私がメイン！？
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230040")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0039")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:はい！<br>ディナタンさん、歌が得意なんですよね？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230041")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("エレイン","0010")
-- ▲直接出力

	--★★エレイン★★:五月女王のディナタンさんが歌うとなれば<br>きっと学園中の生徒が集まりますよ！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230042")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0037")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:でも私…人前で歌うのは苦手で…
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230043")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("エレイン","0007")
-- ▲直接出力

	--★★エレイン★★:先輩、言ってましたよ<br>ディナタンさんの歌には力があるんだって
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230044")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★エレイン★★:ディナタンさんの歌を聞くと心が安らいで<br>いつもの日常に戻れるんだって…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230045")

	change_face(Actor001,"Surprise")

	--★★ディナタン★★:…！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230046")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_1")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_IN_OUT)
wait_time(IMAGE_TIME_WAIT_BEFORE + IMAGE_TIME_IN_OUT)
show_image("103010130", 0.0, 0.0, 0.0,true,false)
fadein(IMAGE_TIME_IN_IN)
wait_time(IMAGE_TIME_IN_IN)
-- ▲直接出力

	--★★ブライアン★★:歌ってくれよ
	Talk(Actor004,"CHRNAME_BRIAN","simple","N","EA_009_0230050")

	change_face(Actor001,"Normal")

	--★★ディナタン★★:うた…
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","EA_009_0230051")


	--★★ブライアン★★:いつものあの<br>やさしい歌
	Talk(Actor004,"CHRNAME_BRIAN","simple","N","EA_009_0230052")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力

	--★★ディナタン★★:…それしか、できないのかな
	Talk(Actor001,"CHRNAME_DINATAN","simple","N","EA_009_0230053")

-- ▼直接出力
change_face(Actor001,"Sad")
-- ▲直接出力

	--★★ブライアン★★:それができるやつが<br>なかなかいねえんだよ
	Talk(Actor004,"CHRNAME_BRIAN","simple","N","EA_009_0230054")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(255,255,255,1.0, IMAGE_TIME_OUT_OUT)
wait_time(IMAGE_TIME_OUT_OUT)
hide_image()
wait_time(IMAGE_TIME_WAIT_AFTER)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
fadein(IMAGE_TIME_OUT_IN)
wait_time(IMAGE_TIME_OUT_IN)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ディナタン★★:………
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230056")


	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0007")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ディナタン★★:私…やります！
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230058")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("エレイン_005","0008")
-- ▲直接出力

	--★★エレイン★★:それなら、会場は大聖堂がいいですね！<br>今、降誕祭用の飾りつけで華やかですし
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230059")


	--★★エレイン★★:ちょっとアレンジすれば<br>新年らしい感じにできると思います！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","EA_009_0230060")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ディナタン","0038")
Appear(Actor003)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ディナタン★★:
	Talk(Actor001,"CHRNAME_DINATAN","speech","L","EA_009_0230061")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(RndCamera008)
PlayActionDirect(Actor003,"to Wlk")
slidemove(Actor003,CharaPos110901_01_006[1],CharaPos110901_01_006[2],CharaPos110901_01_006[3], 2)
wait_time(1.0)
PlayActionDirect(Actor002,"to  Std_Talk")
wait_time(1.0)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor003)
turn_lookat_position(Actor003,CharaPos110901_02_004[1],CharaPos110901_02_004[2],CharaPos110901_02_004[3],0.3)
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ノワール★★:
	Talk(Actor003,"CHRNAME_NOIR","speech","L","EA_009_0230065")

-- ▼直接出力
wait_time(0.8)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("VO_story01")
load_image_preload("103010130", "content_still_10301013_image", "103010130_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115911)
	InitializeCharacter_3D_Preload("101012","001","101012001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","002","101030002","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110901_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
