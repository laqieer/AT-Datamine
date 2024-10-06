-- このluaスクリプトは、CO_101010_0903.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111061_02","111061_02_h")
Include("content_adv_advsmall_111061_02","Template111061_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",-86,CharaPos111061_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName111061_02,CameraPos111061_02_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111061_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_001_01_StdController","to Std_Loop",CameraAssetBundleName111061_02,CameraPos111061_02_003)
	InitializeTemplateRandomCamera111061_02()
	InitializeTemplate111061_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111061)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")

end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:ここが今回の目的地だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030002")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ここは…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:すべての始まりの地であり<br>そしてすべてが終わる地だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030005")


	--★★ランスロット★★:今はまだその扉は固く閉ざされているが<br>いずれお前はここへ足を踏み入れねばならない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030006")

-- ▼直接出力
wait_time(1.5)
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ランスロット★★:――師匠がそう、望んだ場所だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030007")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:父さんが？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ランスロット★★:ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030010")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここにきてまた<br>大事なことを教えてくれないんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030012")

	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:すまない
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030014")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力

	--★★ノワール★★:いいよ、謝らなくて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030015")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:語るべきときが来たら、だろ<br>ちゃんとわかってる
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030016")

-- ▼直接出力
PlayPartVoice("ランスロット", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ランスロット★★:ノワール…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
wait_time(1.5)
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:お前が知りたいことは教えられないが…<br>思い出話をしようか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030019")


	--★★ランスロット★★:ここはな、俺が師匠とＧＳした場所なんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030020")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ランスロットと父さんが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030022")


	--★★ランスロット★★:師匠はかつてニニアンの命を絶ち<br>妖精殺しの咎を負った
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ああ。あんたはそのことを<br>俺たち家族に報せて…コルベニック城を去った
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:師匠の咎の理由が知りたかった<br>弟子として、その汚名を晴らさなければと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030025")

-- ▼直接出力
PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:…だが追いついたときには<br>問い詰める暇などなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030026")


	--★★ランスロット★★:師匠はカレドニア相手に<br>ひとりで、ずっと戦っていて──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030027")

-- ▼直接出力
SkipDefaultMotion(Actor002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("ランスロット", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Pain")

	--★★ランスロット★★:………俺は<br>あの人の前に立てるほど強くはなかった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030028")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ランスロット★★:弱かった<br>今よりもずっと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030030")

-- ▼直接出力
PlayPartVoice("ランスロット", "否定")
-- ▲直接出力

	--★★ランスロット★★:ＧＳするしかなかったんだ<br>師匠にはまだやるべきことがあったのだから
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030032")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ランスロット★★:…なあ、ノワール<br>師匠はな…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030034")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:師匠は…本当に、お前を愛していた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:お前を、ディナタンを…<br>そして、お前の母上を愛していたんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030037")


	--★★ランスロット★★:お前たちを<br>置いていってしまったわけではないんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030039")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ランスロット★★:どう説明すればいいかわからないが──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030040")


	--★★ランスロット★★:辛い道を歩ませてしまった<br>だがそれでもお前たちが生きる道を拓きたいと
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030041")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ランスロット★★:ただ必死に…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030042")

	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ランスロット", "落胆")
-- ▲直接出力

	--★★ランスロット★★:………いや、これは俺の願望に過ぎないか<br>俺と師匠の気持ちが同じであって欲しいという…
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030043")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:だが──
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030044")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:けど、あんたはずっと<br>父さんと一緒にいたんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:…ああ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030047")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:父さんのことを見て<br>父さんに付き合って秘密を抱えてきた
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030048")


	--★★ノワール★★:父さんが遺したいと思った記憶を持っている<br>ランスロットが言うなら、きっとそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030049")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力

	--★★ノワール★★:父さんはランスロットだからこそ<br>記憶を遺してくれたんだと思うし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030050")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:相手がランスロットだからこそ<br>ＧＳを決断したんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030051")


	--★★ノワール★★:父さんは、俺たち家族のためなら<br>どんな無理でもする人だった
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030052")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:でも、ランスロットだからこそ<br>家族のことを託せたんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030053")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:…そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:俺は師匠からたくさんのものをもらった
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030056")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:剣術だけではない<br>学園で皆に教えている知識も師匠譲りのものだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030057")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ランスロット★★:親の顔も知らない俺に家族の温かさと<br>人と触れ合う大事さを教えてくれたのも師匠だ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030058")

-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:あの人が引き合わせてくれたから<br>俺はお前やディナタンとも出会えた
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030059")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:うん
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030060")

	change_face(Actor001,"Smile")

	--★★ノワール★★:俺もよかったと思ってる<br>あんたに出会えて。あんたと兄弟になれて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030061")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ランスロット★★:そうか
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030063")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:い、今さらそんなに喜ぶなよ<br>こっちまで恥ずかしくなるだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030065")


	--★★ランスロット★★:めったに言われないんだ<br>これぐらい喜んだっていいだろう？
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030066")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "笑い")
-- ▲直接出力

	--★★ランスロット★★:ディナタンと違って<br>お前は素直に俺を兄と呼ばないからな
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030068")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:悪かったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030070")

-- ▼直接出力
wait_time(1.5)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ランスロット★★:師匠には、返しきれない恩がある
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030072")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力
	change_face(Actor002,"Serious")

	--★★ランスロット★★:だからこそ…俺はあの人の願いを、本懐を<br>絶対に遂げたいと、そう思うんだ
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030073")


	--★★ランスロット★★:それが、俺にできる唯一の…恩返しだから
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030074")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力

	--★★ノワール★★:ランスロット…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030075")

	change_face(Actor002,"Normal")

	--★★ランスロット★★:ノワール
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030077")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:な、なんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030078")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ランスロット", "肯定3")
-- ▲直接出力

	--★★ランスロット★★:お前はどんどん成長していく
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030079")


	--★★ランスロット★★:誰よりも近くで見ているからこそわかる<br>今のお前になら、世界の命運を託せると
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030080")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ランスロット", "納得")
-- ▲直接出力

	--★★ランスロット★★:もうすぐだ<br>すべてを話す、そのときは
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030081")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力

	--★★ノワール★★:ランスロット？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030082")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
wait_time(1.5)
PlayPartVoice("ランスロット", "肯定")
-- ▲直接出力

	--★★ランスロット★★:さて、そろそろ戻るか<br>あまり遅くなると、ディナタンが心配する
	Talk(Actor002,"CHRNAME_LANCELOT","speech","L","CO_101010_09030084")

-- ▼直接出力
setup_small_camera_start(Camera001)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…ランスロット？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101010_09030086")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("ランスロット_コミュランク", "ランスロット_親密度")
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
	load_area_scene_preload(111061)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101010","001","101010001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111061_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
