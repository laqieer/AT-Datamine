-- このluaスクリプトは、CO_101034_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110161_01","110161_01_h")
Include("content_adv_advsmall_110161_01","Template110161_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110161_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110161_01,CameraPos110161_01_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110161_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit02_Loop",CameraAssetBundleName110161_01,CameraPos110161_01_002)
	InitializeTemplateRandomCamera110161_01()
	InitializeTemplate110161_01()
-- ▼直接出力
DontChangeRandomCamera(true)
turn_lookat(Actor001,Actor002,0)
turn_lookat(Actor002,Actor001,0)
set_enable_auto_lookat_all(false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110161)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
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

	--★★ノワール★★:最近、頑張ってるみたいだなリフレッシュ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020002")


	--★★ノワール★★:「リフレッシュを頑張る」って表現が正しいのかはわからないけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020003")


	--★★ノワール★★:いろんなところで<br>キミを見かけたって声を聞いてる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:夜更けにひたすら校舎の外周を走り続けてたり…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020005")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:ガウェインのリフレッシュ方法ね走ると気分爽快だそうよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020006")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:なんだって夜に走ってたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020007")


	--★★エクセリア★★:朝から走っていて気づいたら夜になっていただけよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020008")


	--★★ノワール★★:あとは前庭で剣と戦鎚を使って椅子を作ったり…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定")
-- ▲直接出力

	--★★エクセリア★★:ガラハッドからＤＩＹを勧められたの少し難しかったわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020010")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、難しくて当たり前だろ剣と戦槌を使ってるんだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020011")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力

	--★★エクセリア★★:ヴォールスが手入れをしてくれた武器よ性能は折り紙付きだわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020012")

	PlayAction(Actor001,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そういう問題じゃないんだが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:他には、食堂に籠もって鬼気迫る表情で野菜を切っていたとも聞いたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:趣味と実益を兼ねたガレス流のリフレッシュを試したときね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020015")


	--★★エクセリア★★:レシピに野菜のサイズの指定があったの０．１ｍｍの誤差もなく切るのは苦労したわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力

	--★★ノワール★★:そんなに真剣に挑んでたらリフレッシュにならないんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020017")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:リフレッシュするときって<br>みんな真剣にならないものなの？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020018")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなことは…いや、でも…多少はゆるめる…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020019")

	change_face(Actor001,"Normal")

	--★★ノワール★★:とにかく！その他もろもろみんなちょっと気味悪がってたぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:せっかくみんなに教えてもらったんだものすべて試してみたいわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:リフレッシュできているかどうかはわからなかったけど…
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020023")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:楽しかったわよ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020024")

-- ▼直接出力
setup_small_camera_start(Camera002)
PlayActionDirect(Actor001,"to LookFor")
-- ▲直接出力

	--★★エクセリア★★:まだ試していないものもあるし気長にベストなものを探していくわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020026")

-- ▼直接出力
setup_small_camera_start(Camera001)
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to Show")
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:それなら、こんなのはどうかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020027")

-- ▼直接出力
setup_small_camera_end()
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:これは？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020029")

-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:花の種。街でもらったんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020030")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ガーデニングとまではいかなくても花を育ててみるのもいいと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020031")

-- ▼直接出力
PlayPartVoice("エクセリア", "挨拶")
-- ▲直接出力

	--★★エクセリア★★:花を育ててどうするの？リリアーナの作物のように食べられないし
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101034_02020034","CO_101034_02020035")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかくだしたくさん育てて売るのも悪くないか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020037")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:私たちで花屋を開くということ？…悪くなさそうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020038")

	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん、冗談
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020039")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:そうなの？楽しそうだと思ったけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020040")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:たしかにエクセリアなら経営もうまいことやれそうだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020041")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こないだリリアーナも言ってたろ育てる過程を楽しむんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020043")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:つまり…？
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:花も生き物だ。毎日少しずつ成長していくそれを見守ってやるのさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020045")

	change_face(Actor001,"Smile")

	--★★ノワール★★:たとえば、観察日記をつけたりして
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020046")

-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:観察日記…？自分の手でデータをとるのね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020047")

-- ▼直接出力
PlayPartVoice("エクセリア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エクセリア★★:少し興味が湧いたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020048")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:では、次は花を育ててみることにするわ…あら？種はいくつか種類があるようね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにが咲くのかはお楽しみらしい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020051")

-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力

	--★★エクセリア★★:まずは種を分類しましょうそれぞれ育てかたの最適解は違うはずだから
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020053")

-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ははっ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("エクセリア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★エクセリア★★:どうしたの？突然笑ったりして
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020055")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:エクセリアは真面目だなと思ってさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020056")


	--★★エクセリア★★:そうかしら？自分では普段どおりのつもりだけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:うん、そうだよ<br>小さいときからそんな感じなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020058")

	change_face(Actor002,"Normal")

	--★★エクセリア★★:どうかしら
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020060")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:この学園に来る前も<br>しっかり者として評判だったんだろうな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020061")

	change_face(Actor002,"Sad")

	--★★エクセリア★★:…そうね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020062")


	--★★ノワール★★:コルベニック城でも気になることがあったらすぐに調べたり、試したりしてたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020063")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エクセリア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:ええ普通のことだと思うけれど
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020064")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:その前は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020065")

-- ▼直接出力
PlayPartVoice("エクセリア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★エクセリア★★:………普通に過ごしていたわ
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エクセリア★★:今日は失礼するわね
	Talk(Actor002,"CHRNAME_EXCELIA","speech","L","CO_101034_02020068")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:エクセリア…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020070")

-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(FADE_TIME)
Hide(Actor002)
set_rot(Actor001,{0,-100,0})
wait_time(0.2)
se_play("SE_ADV_MA_01B112_12_Foot")
setup_small_camera_start()
wait_time(TIME_ELAPSED + 0.5)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺、なんかマズイこと言っちゃったのかな…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101034_02020071")

-- ▼直接出力
local trustParam = set_communication_rankup("エクセリア_コミュランク", "エクセリア_親密度")
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
	InitializeLoad_Preload()
	load_area_scene_preload(110161)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101034","001","101034001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110161_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
