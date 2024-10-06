-- このluaスクリプトは、MA_01C112_02.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110051_02","110051_02_h")
Include("content_adv_advsmall_110051_02","Template110051_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110051_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110051_02_011,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_011)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110051_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_004)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110051_02_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_SitController","to Sit01_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_006)
	Camera005 = SetTemplate("Actor005",nil,CharaPos110051_02_013,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110051_02,CameraPos110051_02_013)
	InitializeTemplateRandomCamera110051_02()
	InitializeTemplate110051_02()
-- ▼直接出力
setup_template_moveobj_110051_02()
set_enable_auto_lookat_all(false)
DontCameraOffset(Actor001)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor002)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor003)
-- ▲直接出力
-- ▼直接出力
DontCameraOffset(Actor004)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115060)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	Actor006 = InitializeCharacter_TextOnly()
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロットたちがまだ戻ってないって？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020002")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:ああ<br>それどころか報告のひとつもない
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_020003")

	change_face(Actor002,"Sad")

	--★★ケイ★★:トリスタンの調査でも<br>足取りはつかめなかった
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_020004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, true)
 --PlayPartVoice("トリスタン", "肯定")
-- ▲直接出力

	--★★トリスタン★★:うん。ロンディニウムまでの動向は<br>確認できたけど、それ以降は…
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C112_020005")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:アーサーにやられたって考えたほうが<br>いいだろうな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020006")


	--★★トリスタン★★:…そうと決まったわけじゃないよね
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C112_020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor003, false)
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。それに…<br>ランスロットたちは聖杯を探しにいった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020008")


	--★★ノワール★★:アーサーは関係がないはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020009")

	PlayAction(Actor004,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor004,"Serious")

	--★★モルドレッド★★:てめえはアーサーと戦ってねえから<br>そんなお気楽なことが言えんだ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020010")


	--★★モルドレッド★★:そもそも<br>アーサーが聖杯を狙ってねえとなぜ言える？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020012")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "悩む")
-- ▲直接出力
	change_face(Actor005,"Surprise")

	--★★ルーシャス★★:…狂犬に同意などしたくはないが…
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020013")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:もし本当に<br>今のアーサーが出てきたのだとしたら
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020014")

	play_head_motion(Actor005, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:たとえ最強騎士といえど<br>おそらくは敵わぬだろうな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020016")


	--★★ノワール★★:………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020017")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:ところで気になってんだがよ<br>ローマがこの円卓に参加するとは思わなかったぜ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020018")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力

	--★★ルーシャス★★:邪魔なら退出しよう
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020019")

-- ▼直接出力
 --PlayPartVoice("ケイ", "怒り")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Anger")

	--★★ケイ★★:おい、やめないか！
	Talk(Actor002,"CHRNAME_KAY","speech","N","MA_01C112_020020")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "激怒")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★トリスタン★★:こんなときにゴチャゴチャ揉めないでよ<br>アーサーがいたときは…
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C112_020021")

-- ▼直接出力
CloseTalkWindow()
wait_time(0.7)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("トリスタン", "挨拶")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★トリスタン★★:…ノワール、キミはどう思う？<br>ローマ皇太子が円卓会議に同席することについて
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C112_020023")

	open_select_window_tag(Actor001,"Normal","MA_01C112_020024","MA_01C112_020025")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺は、いてもらっていいと思う<br>今は仲間…いや、大事な戦力だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:状況を知るためにもいてもらいたい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020028")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "挨拶")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:それはありがたい
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:怪我は大丈夫なのか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020030")

	PlayAction(Actor005,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Normal")

	--★★ルーシャス★★:あの程度、余にはかすりキズにもならん<br>ローマ皇太子だからな
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020031")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定2")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:よく言うぜ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020032")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:正直に言わせてもらえば<br>俺は反対だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:一度は俺たちを裏切った相手だ<br>二度目がないなんて言いきれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020035")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★モルドレッド★★:当然だわな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020036")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:でも聖杯探索とアーサーの対応を<br>同時に進めていかなければならないなかで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020037")

	change_face(Actor001,"Normal")

	--★★ノワール★★:最強騎士が行方不明になった<br>円卓は最大の窮地を迎えている
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020038")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悔しいけど<br>今はひとりでも仲間…戦力が欲しい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力
	change_face(Actor005,"Smile")

	--★★ルーシャス★★:なかなか大局が見れているではないか<br>そこの狂犬と違って
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020040")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★モルドレッド★★:…てめえ、やる気か？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020041")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力
	open_cutin(1,3)
	on_cutin(1,Actor002,"Anger")

	--★★ケイ★★:…ン、ンンッ
	Talk(Actor002,"CHRNAME_KAY","speech","N","MA_01C112_020043")

	close_cutin()
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ケイ★★:くだらない争いをしていても仕方がない<br>話し合いを進めるとしよう
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_020044")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Normal")

	--★★モルドレッド★★:待てよ<br>その前にひとつオレから提案だ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020045")

	change_face(Actor001,"Normal")

	--★★ノワール★★:提案？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020046")


	--★★モルドレッド★★:王座が空席じゃ格好がつかねえって話だ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020047")


	--★★ケイ★★:…なにが言いたい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_020048")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor004,"to Sit01_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルドレッド★★:飾りをやってやろうってんだよ<br>あのヤロウが無視できねえようにな
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020049")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:ま、正式に王位をブン取る前の<br>準備運動みてえなもんだ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020050")

	change_face(Actor004,"Normal")

	--★★モルドレッド★★:んでもって、王には騎士が必要だよなぁ…<br>…ノワール
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
keep_ik_lookat(Actor004, Actor001, "J_Head")
lookWeight = {1.0, 0, 0.5, 0.35}
lookat_delay_weight(Actor004, lookWeight,1.0)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "喜び")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★モルドレッド★★:――てめえに騎士筆頭を任せる
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020053")

-- ▼直接出力
 --PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:俺が騎士筆頭…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020054")

	PlayAction(Actor004,"to Sit01_Talk")

	--★★モルドレッド★★:このオレの騎士を担うんだ<br>継承者くらいじゃなきゃ箔がつかねぇだろ？
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020055")

	change_face(Actor004,"Normal")

	--★★モルドレッド★★:最強騎士が戻るまで、精々場を繋いどけ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020056")

-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:けど、俺にそんな――…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020057")

-- ▼直接出力
 --PlayPartVoice("ケイ", "悩む")
-- ▲直接出力

	--★★ケイ★★:…確かに、それくらいの責任を負うてもらわねば<br>この状況は打破できぬかもしれん
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_020058")

-- ▼直接出力
 --PlayPartVoice("ケイ", "肯定2")
-- ▲直接出力

	--★★ケイ★★:貴公以外にはいない、継承者よ<br>王とともにブリテンを救って欲しい
	Talk(Actor002,"CHRNAME_KAY","speech","L","MA_01C112_020059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "悩む")
-- ▲直接出力

	--★★モルドレッド★★:…さて。それじゃさっそく<br>今後どうするかを決めようぜ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020061")


	--★★モルドレッド★★:オレぁランスロットよりも<br>先に聖杯を探すべきだと思うぜ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020062")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力

	--★★モルドレッド★★:アーサーのあの力に聖杯が加わったら<br>ちっとばかし厄介な相手になりそうだ
	Talk(Actor004,"CHRNAME_MORDRED","speech","L","MA_01C112_020063")

-- ▼直接出力
 --PlayPartVoice("トリスタン", "肯定3")
-- ▲直接出力

	--★★トリスタン★★:それに聖杯はボクたちの切り札だ<br>奪われるのはかなりの痛手だよ
	Talk(Actor003,"CHRNAME_TRISTAN","speech","L","MA_01C112_020064")

	change_face(Actor005,"Normal")

	--★★ルーシャス★★:…もし万が一ランスロットが<br>生存しているのだとすれば
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020065")

-- ▼直接出力
 --PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:救出に向かうべきではないのか<br>やつこそ大事な戦力であろう
	Talk(Actor005,"CHRNAME_LUCIUS","speech","L","MA_01C112_020066")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…聖杯を探しに行ったランスロットたちの<br>最後の足取りはロンディニウム…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020067")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:そこに手掛かりがあるかもしれない<br>ロンディニウムに行こう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C112_020068")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115060)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor005,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110051_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
