-- このluaスクリプトは、MA_01C109_901.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_005)
	Camera002 = SetTemplate("Actor002",-90,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_508_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_506_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_002)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_007)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
hotdog = setup_prop_object(10102001)
-- ▲直接出力
-- ▼直接出力
hotdog_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
on_parent(hotdog,Actor004, "Loc_weapon_constrint_R", hotdog_offset)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
-- ▲直接出力
-- ▼直接出力
turn_lookat(Actor003,Actor001, 0)
 --turn_lookat(Actor002,Actor001, 0)
-- ▲直接出力
-- ▼直接出力
	-- 背景移動回転スケール
	local bg = get_object("BG")
	set_pos(bg,{-10,0,10})

	-- 固定モブ移動回転スケール
	local pro = get_object("Pro_1101_45")
	set_pos(pro,{-10,0,10})
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115120)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","挨拶")
-- ▲直接出力

	--★★クラリス★★:あっ、ノワールくん<br>こんにちは～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010002")

-- ▼直接出力
 --PlayPartVoice("ノワール","挨拶")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:クラリスにキッスさんじゃないか<br>珍しい組み合わせだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010003")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("キッス","挨拶")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:ラビットちゃん、ちょうどいいところに！<br>憲兵団の仕事の件で相談があるのよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010004")

-- ▼直接出力
setup_small_camera_start(RndCamera001)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:大きな戦闘が続いていたこともあって<br>ここのところ憲兵団の仕事をしてなかったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010005")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:今なら特に用事もないし<br>俺で良ければ手伝うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010006")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("キッス","笑い")
-- ▲直接出力

	--★★キッス★★:ありがとう<br>詳しい説明はお願いしていい、クラリス？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010007")

	PlayAction(Actor003,"to Bow")
-- ▼直接出力
 --PlayPartVoice("クラリス","肯定")
-- ▲直接出力

	--★★クラリス★★:はい～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010008")


	--★★クラリス★★:少し前に、アストラット郷にお住みの方が<br>大聖堂にいらっしゃってですね
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010009")


	--★★クラリス★★:近くの孤児院の周辺で<br>バルバロイが頻繁に見かけられるようになって
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★クラリス★★:孤児院の子供たちが心配だから<br>バルバロイを退治してほしいとのことなんです
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010011")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クラリス","悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★クラリス★★:モルくんに相談しようと思ったのですが<br>最近、学園を留守にしがちなんですよ～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010012")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("キッス","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:それでアタシのところに相談にきたってわけ
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010013")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定")
-- ▲直接出力

	--★★ノワール★★:なるほどな<br>わかった、すぐに出ようか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010014")

-- ▼直接出力
Appear(Actor005)
turn_lookat(Actor003,Actor005, 0)
turn_lookat(Actor002,Actor005, 0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド","挨拶")
-- ▲直接出力

	--★★モルドレッド★★:ちょっと待て、継承者
	Talk(Actor005,"CHRNAME_NAMELES","speech","N","MA_01C109_9010015")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:モルくん<br>戻ってきてたんですか～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010016")

-- ▼直接出力
--モルドレッド,CHRNAME_MORDRED @名前変更
-- ▲直接出力

	--★★モルドレッド★★:クラリスはオレに相談しようとしてたんだ<br>だからオレが行く
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010017")

	PlayAction(Actor005,"to  Std_Worry")

	--★★モルドレッド★★:てめえはすっこんでろ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010018")

-- ▼直接出力
wait_time(0.5)
PlayActionDirect(Actor001,"to  Std_Worry")
change_face(Actor001,"Sad")
-- ▲直接出力
	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("クラリス","否定")
-- ▲直接出力

	--★★クラリス★★:え～？でも、モルくん<br>戻って来たばかりで疲れてるでしょう？
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010020")

-- ▼直接出力
 --PlayPartVoice("キッス","悩む")
-- ▲直接出力

	--★★キッス★★:一緒に行けばいいんじゃない？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010021")

-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:は？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド","驚き")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★モルドレッド★★:はァ！？
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010023")

-- ▼直接出力
 --PlayPartVoice("キッス","悲しみ")
-- ▲直接出力

	--★★キッス★★:クラリスが実際に相談したのはラビットちゃん<br>でも、モルドレッドくんも手伝いたいと言ってる
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★キッス★★:だったら、一緒に行けばいいじゃない
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010025")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Talk")
	change_face(Actor005,"Anger")

	--★★モルドレッド★★:手伝いたいなんて言ったつもりはねえ！
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010026")

	change_face(Actor002,"Normal")

	--★★キッス★★:モルドレッドくんは疲れてる<br>助っ人がいたほうがラビットちゃんもラクできる
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010027")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("キッス","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★キッス★★:どう？<br>グッドアイデアじゃない？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010028")

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
 --PlayPartVoice("クラリス","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★クラリス★★:グッドアイデアですね～！
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010029")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド","激怒")
-- ▲直接出力

	--★★モルドレッド★★:疲れてるなんて言ったつもりもねえ！
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010030")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は別にいいんだけどさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010031")

-- ▼直接出力
Appear(Actor004)
SkipDefaultMotion(Actor004)
PlayActionDirect(Actor004,"to EatIdle")
turn_chara(Actor005, 22, 0)
wait_time(0.2)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("アーサー","挨拶")
-- ▲直接出力

	--★★アーサー★★:いいじゃないか<br>円卓の騎士同士仲良くするのは大変結構
	Talk(Actor004,"CHRNAME_NAMELES","speech","N","MA_01C109_9010032")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
 --lookWeight = {0.9, 0, 0.7, 0.35}
 --lookat_delay_weight(Actor001, lookWeight,1)
 --keep_ik_lookat(Actor001, Actor004, "J_Head")
PlayActionDirect(Actor001,"to Wlk")
turn_chara(Actor001,-31,0.5)
wait_time(0.5)
PlayActionDirect(Actor001,"to Std_Loop")
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:アーサー<br>どうしてここに？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C109_9010033")

-- ▼直接出力
--アーサー,CHRNAME_ARTHUR @名前変更
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:なあに、ちょっとヤボ用でな！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010034")

-- ▼直接出力
 --PlayPartVoice("モルドレッド","肯定3")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★モルドレッド★★:どうせ買い食いだろ
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010035")

-- ▼直接出力
 --PlayPartVoice("アーサー","悩む")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:まあ、俺のヤボ用のことは<br>おいておいてだ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010036")


	--★★アーサー★★:ノワールとモルドレッドとで<br>一緒に任務にあたったことはないだろう？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010037")


	--★★アーサー★★:親睦を深める<br>またとないチャンスだと思わないか？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010038")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("クラリス","肯定")
-- ▲直接出力

	--★★クラリス★★:思います～<br>グッドグッドアイデアですね～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010039")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","肯定")
-- ▲直接出力

	--★★アーサー★★:だろう？<br>さらに、もうひとつアイデアがある
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010041")

-- ▼直接出力
 --PlayPartVoice("キッス","肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★キッス★★:どんなアイデアなんです？
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010042")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★アーサー★★:俺も同行するというのはどうだ！？
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010043")

-- ▼直接出力
 --PlayPartVoice("ノワール","驚き")
-- ▲直接出力
	open_cutin(2,1)
	on_cutin(1,Actor001,"Surprise")

	--★★ノワール★★:…は？は？？
	Talk(Actor001,"CHRNAME_NOIR","speech","N","MA_01C109_9010044")

	PlayAction(Actor005,"to  Std_Surp")
-- ▼直接出力
 --PlayPartVoice("モルドレッド","驚き")
-- ▲直接出力
	on_cutin(2,Actor005,"Anger")

	--★★モルドレッド★★:はァァ～～～～～ッ！？<br>てめえは国王だろ！円卓の間で大人しくしてろ！
	Talk(Actor005,"CHRNAME_MORDRED","speech","N","MA_01C109_9010045")

	close_cutin()
-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★アーサー★★:それがなあ、なぜか今日は腹が重くてな<br>運動したい気分なんだよ
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010046")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
	change_face(Actor004,"Smile")

	--★★アーサー★★:そうと決まればすぐに出発だ<br>行くぞモルドレッド、ノワール！
	Talk(Actor004,"CHRNAME_ARTHUR","speech","L","MA_01C109_9010047")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド","激怒")
-- ▲直接出力

	--★★モルドレッド★★:おい、ちょっと待て！<br>オレァてめえの同行を許可した覚えはねえ！
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010048")

-- ▼直接出力
setup_small_camera_start(Camera005)
Hide(Actor004)
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Worry")
	change_face(Actor005,"Surprise")

	--★★モルドレッド★★:その前に継承者と一緒ってのもだな…<br>って、人の話を聞け！おい！！
	Talk(Actor005,"CHRNAME_MORDRED","speech","L","MA_01C109_9010049")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("クラリス","驚き")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★クラリス★★:はわわ～<br>待ってください、ふたりとも～
	Talk(Actor003,"CHRNAME_CLARICE","speech","L","MA_01C109_9010050")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
lookat_delay_weight_reset(Actor001 , 1)
turn_chara(Actor001, 22, 0)
Hide(Actor005)
Hide(Actor003)
setup_small_camera_start(RndCamera001)
 --フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("キッス","笑い")
-- ▲直接出力

	--★★キッス★★:思いもよらず大所帯になっちゃったけど<br>…よろしくね、ラビットちゃん
	Talk(Actor002,"CHRNAME_KISS","speech","L","MA_01C109_9010051")

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
	InitializeLoad_Preload()
	load_area_scene_preload(115120)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101023","001","101023001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101015","001","101015001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
