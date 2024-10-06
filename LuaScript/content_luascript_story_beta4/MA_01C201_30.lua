-- このluaスクリプトは、MA_01C201_30.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110101_01","110101_01_h")
Include("content_adv_advsmall_110101_01","Template110101_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",115,CharaPos110101_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_006)
	Camera002 = SetTemplate("Actor002",-180,CharaPos110101_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_512_01_StdController","to Std_Loop",CameraAssetBundleName110101_01,CameraPos110101_01_003)
	InitializeTemplateRandomCamera110101_01()
	InitializeTemplate110101_01()
-- ▼直接出力
load_image("10104024", "content_still_10104024_image", "101040240_StillImage")
Hide(Actor001)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115104)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101009","002","101009002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★ノワール2D★★:どういうことなんですか
	Talk(Actor003,"CHRNAME_NOIR","speech","L","MA_01C201_300002")

-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor001)
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★マーリン★★:………
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300003")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:マーリン様<br>あなたは知ってるんですか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300004")

-- ▼直接出力
wait_time(0.5)
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…知ってたんですか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300005")

-- ▼直接出力
CloseTalkWindow()
PlayActionDirect(Actor002,"to Wlk")
turn_chara(Actor002,-53.4,0.9)
wait_time(0.9)
PlayActionDirect(Actor002,"to Std_Loop")
play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▲直接出力

	--★★マーリン★★:…ええ
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300006")


	--★★マーリン★★:すべては湖の妖精の過ちから始まりました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300007")

	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:妖精の過ち…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300008")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Anger")

	--★★マーリン★★:そう。あるひとりの男と妖精が愛し合い<br>妖精は子を成した
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300009")


	--★★マーリン★★:ディナタンはあなたの妹ではない
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300010")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★マーリン★★:ディナタンは――アーサーの姉です
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300011")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンが姉なわけがない<br>アーサーは俺たちよりずっと年上だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300012")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マーリン★★:あなたはあの森を覚えていますか<br>アーサーが学園を棄てたときに
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300013")


	--★★マーリン★★:あなたたちが妖精の力によって<br>飛ばされたあの森を
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300014")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…覚えています<br>でも、なんだか森の記憶は曖昧で
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300015")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:森は人間に真実を伝えることがありますが<br>森から出たときに人間は真実を忘れてしまう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300016")


	--★★マーリン★★:森とはつまり妖精の総意です<br>森があなたたちを守ろうとした
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:妖精の力は強大です<br>死してなお自らの子を守る
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…意味がわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300019")


	--★★マーリン★★:ニニアンはアーサー様の父親である<br>ユーサー王と愛し合い
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300020")


	--★★マーリン★★:密かにあの森で子供を産みました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300021")


	--★★マーリン★★:それがディナタン
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:そしてニニアンとディナタンは数ヶ月…<br>現実世界ではほんのわずかなあいだ森で過ごし
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300023")

	PlayAction(Actor002,"to  Std_No")

	--★★マーリン★★:けれどニニアンは聖杯のために<br>森を出なければならなくなった
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300024")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力

	--★★マーリン★★:ニニアンは森を出るときに<br>ディナタンをあなたの父に預けた
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300025")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:ディナタンが自分の…<br>妖精の子供だと知られないために
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300026")


	--★★マーリン★★:そしてユーサー王は森から出て記憶を失い…<br>結婚して、もうひとりの子供が生まれました
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300027")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:その王子がアーサーです
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C201_300029","MA_01C201_300030")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Anger")

	--★★ノワール★★:ウソだ！ディナタンが妖精の娘だなんて<br>そんな話、信じられない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300032")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★マーリン★★:なにか覚えはありませんか？<br>ディナタンに備わる、常人にはない力を
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300033")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:常人にはない…力…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300035")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ディナタンは俺の妹じゃ、ない…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300037")

	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンの本当の兄妹は<br>俺ではなく、アーサー………？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300038")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:そんな、そんなことって………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300039")

	goto Block1end

::Block1end::
	change_face(Actor001,"Normal")

	--★★ノワール★★:…でも、どうしてあなたがそのことを…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300041")

	change_face(Actor002,"Normal")

	--★★マーリン★★:妖精とはなんだと思いますか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300042")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:聖杯の導き手じゃないのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300043")


	--★★マーリン★★:聖杯とは願いを叶えるためのもの<br>我々の願いはバルバロイを祓うこと
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300044")


	--★★マーリン★★:バルバロイは記憶を喰らう<br>そして聖遺物化されると記憶が失われる
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300046")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:ここに類似点はありませんか
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300047")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:…記憶………！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300048")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★マーリン★★:そして森での出来事の<br>記憶を人間は失ってしまう
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300049")


	--★★マーリン★★:記憶に関わるそのすべてを<br>妖精は把握しています
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300050")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイとも繋がりがあるっていうのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300051")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★マーリン★★:ないとはいえません<br>無関係な者が祓うわけにはいきませんから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300052")


	--★★マーリン★★:そして妖精は忘れない
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300053")

	PlayAction(Actor002,"to  Std_Talk")

	--★★マーリン★★:継承者以外が忘れてしまうとしたら<br>忘れてしまったことを誰が伝えるのです？
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300054")


	--★★マーリン★★:森には記憶が詰まっています
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:妖精は森からその切れ端を伝えられるに<br>過ぎません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300056")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:森での記憶…俺は…<br>俺も、あの森でのことを忘れている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_No")

	--★★マーリン★★:あなたたちのことを私は森から<br>聞いてはいません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300058")

	change_face(Actor002,"Sad")

	--★★マーリン★★:でも、妖精の血を半分持つディナタンは<br>もしかすると―――…
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300059")

	change_face(Actor001,"Normal")

	--★★ノワール★★:あの森が俺たちを守ってくれた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300060")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★マーリン★★:そしてあなたたちが育った湖も<br>また妖精の力の強い場所
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300061")


	--★★マーリン★★:あなたたちは始めから<br>妖精とともにあった
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300062")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★マーリン★★:継承者と妖精の繋がりは我々の想像より<br>強いものなのかもしれません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300063")


	--★★マーリン★★:そして妖精の血をひくディナタンは<br>あなたを守ろうしている
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300064")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…妖精殺しの息子だと<br>ずっと言われてきたんです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300065")

	PlayAction(Actor001,"to  Std_Sad02")

	--★★ノワール★★:なのに、今更そんなこと――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300066")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★マーリン★★:…これ以上<br>私からお話しできることはありません
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300067")


	--★★マーリン★★:すべての真実は森ととも共に<br>灰になってしまいましたから
	Talk(Actor002,"CHRNAME_MERLIN","speech","L","MA_01C201_300068")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor002)
DontChangeRandomCamera(false)
manager.CloseupUpExclusiveCamera(Actor001)
DontChangeRandomCamera(true)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
DontChangeRandomCamera(false)
-- ▲直接出力

	--★★ノワール★★:俺たちは兄妹じゃない…<br>そしてディナタンは妖精の血が半分
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C201_300070")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
fadeout(0,0,0,1.0,1.0)
wait_time(1.5)
close_textbox_base()
-- ▲直接出力
-- ▼直接出力
show_image("10104024", 0.0, 0.0, 0.0 ,true,false)
fadein(2.0)
wait_time(1.5)
 voiceSignalS = voice_play("VO_story01_D_1283")
wait_time(1.0)
	while voiceSignalS.IsProccessing() do
		coroutine.yield()
	end
wait_time(1.5)
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
load_image_preload("10104024", "content_still_10104024_image", "101040240_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(115104)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101020","001","101020001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101009","002","101009002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110101_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
