-- このluaスクリプトは、EA_069_024.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112021_01","112021_01_h")
Include("content_adv_advsmall_112021_01","Template112021_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112021_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_503_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	Camera003 = SetTemplate("Actor004",nil,CharaPos112021_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_006)
	Camera004 = SetTemplate("Actor005",nil,CharaPos112021_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_502_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_004)
	Camera005 = SetTemplate("Actor006",nil,CharaPos112021_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName112021_01,CameraPos112021_01_005)
	InitializeTemplateRandomCamera112021_01()
	InitializeTemplate112021_01()
-- ▼直接出力
load_sound("BGM_Area_Noon")
load_sound("BGM_Area_Acoustic")

load_image("101010150", "content_still_10101015_image", "101010150_StillImage") -- 白背景
set_pos(Actor005, {4.537, 0, -0.439})
Hide(Actor005)

PlayActionDirect(Actor001,"to  Std_Sad01")
-- ▲直接出力
-- ▼直接出力
set_pos(Actor006,{-4.73, 0, 0.362})
Hide(Actor006)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112021)
	Actor001 = InitializeCharacter_3D("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101040","001","101040001")
	Actor004 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor006,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	change_face(Actor001,"Sad")

	--★★ギネマウア★★:………
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240001")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力

	--★★アーサー★★:４ヶ月も経っているのに、<br>まだ俺は彼女を笑顔に出来ていない
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0240002")


	--★★アーサー★★:このままでは約束破りになってしまう
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0240003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア_004","0017")
-- ▲直接出力

	--★★ギネマウア★★:…それは――…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240004")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0008")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★アーサー★★:だから挽回のチャンスをもらいたくてな<br>俺は一応、彼女の婚約者なわけだし？
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0240005")


	--★★ギネマウア★★:アーサー様…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240006")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_2")
voice_play("VO_101040_sp_0002_2")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★ケイ★★:アーサー！
	Talk(Actor003,"CHRNAME_KAY","speech","L","EA_069_0240007")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn(Actor002, 0, 75-180, 0, 0.5+0.3)
wait_time(0.3)

PlayActionDirect(Actor004,"to Wlk")
turn(Actor004, 0, 107-180, 0, 0.5+0.3)
wait_time(0.2+0.3)
PlayActionDirect(Actor002,"to Std_Loop")
wait_time(0.3)
PlayActionDirect(Actor004,"to Std_Loop")

PlayPartVoiceDirect("アーサー","0014")
bgm_play("BGM_Area_Noon")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★アーサー★★:やばい、義兄さんだ！さては例の仕事の件か…？<br>すまんが、ちょっと行ってくる！
	Talk(Actor002,"CHRNAME_ARTHUR","speech","L","EA_069_0240008")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
PlayActionDirect(Actor002,"to Run")
slidemove(Actor002,{-5.045, 0, 0.362}, 1.5)
wait_time(2.0)
Hide(Actor002)
PlayPartVoiceDirect("マーリン_005","0014")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マーリン★★:まったくもう…<br>本当に慌ただしいですね、我が王は
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor004,"to Wlk")
turn(Actor004, 0, 107, 0, 0.5+0.3)
wait_time(0.5+0.3)
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★マーリン★★:ではアーサー様が仕事を終わらせている間に<br>私たちは準備をしてしまいましょうか
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0015")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:準備？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240012")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0007")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マーリン★★:はい。別荘のまわりにはお店がないので<br>必要なものをここで揃えなくては
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★マーリン★★:楽しい夏休みにしたいですからね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240014")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0023")
SkipDefaultMotion(Actor001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ギネマウア★★:…どうして
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240015")

	change_face(Actor004,"Normal")

	--★★マーリン★★:え？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240016")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ギネマウア★★:あなたも、アーサー様も…<br>どうしてそこまで親身になってくださるのです
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240017")

	PlayAction(Actor001,"to  Std_No")

	--★★ギネマウア★★:私たちはなにも返せないのに…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240018")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
-- ▲直接出力

	--★★マーリン★★:そんなこと気になさる必要はありませんよ
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240019")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:ですが！
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240020")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)

	--★★マーリン★★:あのかたはギネヴィア様を放っておけないのです<br>まるで昔の自分を見ているようだと
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240021")

-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:え…？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0007")
bgm_play("BGM_ADV_Prison")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★マーリン★★:あのかたは幼い頃<br>バルバロイにお母様を殺されました
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240023")


	--★★マーリン★★:その後、バルバロイの脅威から逃れるため<br>辺境の孤児院へ送られ身分を隠し生きてきました
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240024")


	--★★マーリン★★:大切な人と、当たり前の暮らしを奪われ…<br>あの頃の彼は心を閉ざしていました
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240025")

	PlayAction(Actor004,"to  Std_No")

	--★★マーリン★★:今では想像もつかないくらいに
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240026")

	change_face(Actor001,"Sad")

	--★★ギネマウア★★:………
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240027")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0010")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マーリン★★:ですが、それでも…村での穏やかな時間が<br>彼の心に安らぎを与えてくれた
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")

	--★★マーリン★★:王子ではなくただのひとりの子供に戻る時間は<br>今思えば――
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240029")


	--★★マーリン★★:ずっと張りつめていた彼にとって<br>良い『気晴らし』になったのかもしれない
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0038")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ギネマウア★★:…きっと、そうだと思います
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン","0036")
-- ▲直接出力

	--★★マーリン★★:ありがとうございます
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240033")

	change_face(Actor004,"Normal")

	--★★マーリン★★:アーサー様がギネヴィア様を気遣うのはきっと<br>あのときの気持ちを覚えているから
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240034")

	PlayAction(Actor004,"to  Std_Talk")

	--★★マーリン★★:そして私もひとりで寂しそうにしているかたを<br>放っておきたくはありません
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240035")


	--★★マーリン★★:今も、昔も
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240036")

	PlayAction(Actor001,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0010")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ギネマウア★★:マーリン様…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240037")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.3)
Appear(Actor006)
wait_time(0.3)
PlayActionDirect(Actor006,"to Wlk")
slidemove(Actor006,{0.218, 0, 0.362}, 2.5)
wait_time(2.5)
PlayActionDirect(Actor006,"to Std_Loop")
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor006,"to Greet_one")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0011")
bgm_play("BGM_Area_Noon")
-- ▲直接出力

	--★★アーサー2★★:どうやら、話はまとまったようだな？
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0028")
-- ▲直接出力

	--★★マーリン★★:あら、お仕事はもう終わったのですか？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240040")

	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★アーサー2★★:ああ！ついでに夏休みをもぎとってきたぞ！<br>『領地の視察』という名目付きではあるがな
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240041")


	--★★アーサー2★★:これで心置きなく楽しめる！<br>別荘の近くは海もあるから涼もとれるぞ
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240042")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor002,"to Wlk")
turn(Actor002, 0, 75+15, 0, 0.3+0.2)
wait_time(0.3+0.2)
PlayPartVoiceDirect("アーサー","0009")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★アーサー2★★:いやあ、楽しみだな！ギネヴィア！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240043")

-- ▼直接出力
Appear(Actor005)
IN_WALK(Actor005,CharaPos112021_01_004)
PlayPartVoiceDirect("ギネマウア","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ギネマウア★★:え？
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240044")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
setup_small_camera_start()

PlayActionDirect(Actor001,"to Wlk")
turn(Actor001, 0, 150, 0, 0.3+0.2)
wait_time(0.3+0.2)
-- ▲直接出力

	--★★ギネマウア★★:ギネヴィア！？あなた、いつの間に
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240046")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0014")
-- ▲直接出力
	change_face(Actor005,"Sad")

	--★★ギネヴィア★★:様子を覗いてたら楽しそうな話してるから<br>ついうっかり身を乗り出しちゃったとか…
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0240048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
SkipDefaultMotion(Actor005)
-- ▲直接出力

	--★★ギネヴィア★★:べ、別に、お姉ちゃんを追いかけて<br>マーケットに来たとかじゃないから！
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0240049")


	--★★ギネヴィア★★:様子を覗いてたら楽しそうな話してるから<br>ついうっかり身を乗り出しちゃったとか…
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0240050")

	PlayAction(Actor005,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","0053")
-- ▲直接出力
	change_face(Actor005,"Shy")

	--★★ギネヴィア★★:全然、そんなんじゃないから！！
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0240051")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ギネマウア","0025")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ギネマウア★★:あのねぇ…
	Talk(Actor001,"CHRNAME_GWENHWYMAWR","speech","L","EA_069_0240052")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0026")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★マーリン★★:楽しい予定があると<br>ワクワクしてしまいますよね
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240053")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor006, "Nod", 0.3, 1.0, false)

	--★★アーサー2★★:うんうん、わかるわかる
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240054")

	PlayAction(Actor006,"to  Std_Talk")
-- ▼直接出力
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor002,"to Wlk")
turn(Actor001, 0, 290, 0, 0.3+0.2)
turn(Actor002, 0, 75, 0, 0.3+0.2)
wait_time(0.3+0.2)
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoiceDirect("アーサー","0011")
-- ▲直接出力
	change_face(Actor006,"Normal")

	--★★アーサー2★★:よし、そうと決まれば善は急げだ<br>さっそく向かうとしよう！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240055")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★マーリン★★:ところで、アーサー様。その別荘って<br>管理のかたとかいらっしゃるんですか？
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240056")


	--★★アーサー2★★:いや…どうだったかな<br>正直、存在を思い出したのもつい最近だし
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240057")

-- ▼直接出力
PlayPartVoiceDirect("マーリン","0028")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★マーリン★★:え…
	Talk(Actor004,"CHRNAME_MERLIN","speech","L","EA_069_0240058")

	PlayAction(Actor006,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("アーサー","0019")
-- ▲直接出力

	--★★アーサー2★★:うーん…そういえば<br>あの別荘に最後に行ったのはいつだったか…
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240059")

	PlayAction(Actor004,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("マーリン_005","0033")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor004,"Sad")

	--★★マーリン★★:
	Talk(Actor004,"CHRNAME_MERLIN","speech","N","EA_069_0240060")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
fadeout(0, 0, 0, 0, 1.0)
wait_time(1.0)
CloseTalkWindow()
close_cutin()
show_image("101010150", 0, 0, 0, true, false)
set_scale_image(20, 20)
wait_time(1.0)
fadein(2.0)
wait_time(2.0)
PlayPartVoiceDirect("アーサー","0012")
bgm_play("BGM_Area_Acoustic")
-- ▲直接出力
	change_face(Actor006,"Smile")

	--★★アーサー2★★:着いたぞ！<br>ここがログレス王家の別荘だ！
	Talk(Actor006,"CHRNAME_ARTHUR","speech","L","EA_069_0240062")

-- ▼直接出力
PlayPartVoiceDirect("ギネヴィア","swim_0047")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ギネヴィア★★:わ～！すっごい！広いし、建物も立派！！<br>けど――
	Talk(Actor005,"CHRNAME_GUINEVERE","speech","L","EA_069_0240063")

-- ▼直接出力
bgm_play("Stop_BGM_Bus_MidFade")
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_Area_Noon")
preload_sound("BGM_Area_Acoustic")
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112021)
	InitializeCharacter_3D_Preload("101016","001","101016001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101040","001","101040001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor005")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor006")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor006,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112021_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
